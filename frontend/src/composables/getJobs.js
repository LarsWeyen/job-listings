import { ref } from 'vue'

const getJobs = () =>{
    const jobs= ref([])

    const error = ref(null)

    const load = async ()=>{
      try{
        let data = await fetch("http://localhost:5000/api/jobs")
        if(!data.ok){
          throw Error('no data available')
        }
        jobs.value = await data.json()
      }
      catch(err){
        error.value = err.message
        console.log(error.value)
      }
    }
    return {jobs,error,load}
}

export default getJobs