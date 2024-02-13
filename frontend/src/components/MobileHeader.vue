<script setup>
import mobileHeader from '../images/bg-header-mobile.svg'

</script>

<template>
    <header>
        <img class="mobile-header-img" v-bind:src="mobileHeader" alt="header mobile svg">
    </header>
</template>

<style scoped>
    .mobile-header-img{
        max-width:100%;
        max-height:100%;
        object-fit: contain;
        background-color: hsl(180, 29%, 50%);
    }
    header{
        position: absolute;
        z-index: -1;
    }
</style>
