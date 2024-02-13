<template>
<div class="jobs-container">
    <div v-for="job in jobs" :key="job.id"> 
        <SingleJob :job="job" />
    </div>
</div>
</template>

<script>
import { ref } from 'vue'
import SingleJob from './SingleJob.vue'
export default{
    props: ['jobs'],
    components: {SingleJob},
    setup(){

    }
}
</script>

<style scoped>
.jobs-container{
    display: flex;
    flex-direction: column;
    gap: 2rem;
}
</style>
