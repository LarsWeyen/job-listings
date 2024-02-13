<template>
<div class="job-container">
    <img v-bind:src="image" v-bind:alt="job.company">
    <span>{{job.company}}</span>
    <span>{{ job.title }}</span>
    <div>
       <ul>
        <li>1d ago</li>
        <li>{{ job.type }}</li>
        <li>{{ job.location }}</li>
       </ul>
    </div>
    <hr>
    <div class="job-tags-container">
        <div v-for="tag in job.tags">{{ tag }}</div>
    </div>
</div>
</template>

<script>
import { ref } from 'vue'
import { computed } from '@vue/reactivity';


export default{
    props: ['job'],
    setup(props){
        const image = computed(()=>{
            return new URL('.'+props.job.image, import.meta.url).href
        })
        return {image}
    }
}
</script>

<style scoped>
.job-container{
    border-radius: 6px;
    background-color: #FFFFFF;
}
</style>
    