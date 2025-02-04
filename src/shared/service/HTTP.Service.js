import axios from "axios";


//create axios with basic configuration

const axiosHTTP = axios.create({
    baseURL : "http://localhost:3001" 
})

//create interceptor fo request

axiosHTTP.interceptors.request.use(
    (config)=>{
        const token = !!sessionStorage.getItem("accessToken");
        return {
            ...config,
            headers:{
                ...(token && {'Authorization':`Bearer ${sessionStorage.getItem("accessToken")}`}),
                ...config.headers
            }
        }
    },
    (error)=>{
        return Promise.reject(error)
    }
);

//create interceptor for response

axiosHTTP.interceptors.response.use(
    (response)=>{
        return response.data;
    },
    (error)=>{
        return Promise.reject(error);
    }
)


//Global Request HTTp Request

export const GET = (url,header={})=>{
    return axiosHTTP.get(url,{headers:header})
}

export const DELETE = (url,header={})=>{
    return axiosHTTP.delete(url,{headers:header})
}

export const POST = (url,payload,header={})=>{
    return axiosHTTP.post(url,payload,{headers:header})
}

export const PUT = (url,payload,header={})=>{
    return axiosHTTP.put(url,payload,{headers:header})
}