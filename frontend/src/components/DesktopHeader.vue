<script setup>
import desktopHeader from '../images/bg-header-desktop.svg'

</script>

<template>
    <header>
        <img class="mobile-header-img" v-bind:src="desktopHeader" alt="header desktop svg">
    </header>
</template>

<style scoped>
    .mobile-header-img{
        max-width:100%;
        max-height:100%;
        
        background-color: hsl(180, 29%, 50%);
    }
    header{
        position: absolute;
        z-index: -1;
    }
</style>
