

<template>

 <main>
    <div class="div-space"></div>
    <FilterBox />
    <div>
        <!-- <div>error</div> -->
        <div>
            <JobList :jobs="jobs" />
        </div>
    </div>
 </main>
</template>

<script>
import FilterBox from './FilterBox.vue';
import JobList from './JobList.vue'
import getJobs from '../composables/getJobs'

export default{
    name: "JobListings",
    components: {FilterBox,JobList},
    setup(){
        const {jobs,error,load} = getJobs();

        load();
        
        return {jobs,error}
    }
}
</script>

<style scoped>
main{
    margin: 0 auto;
    width: 90%;
    display: flex;
    flex-direction: column;
}

.div-space{
    height: 120px;
}
</style>
