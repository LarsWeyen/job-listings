<script>
import { RouterLink, RouterView } from 'vue-router'
import MobileHeader from './components/MobileHeader.vue'
import DesktopHeader from './components/DesktopHeader.vue'
import {ref, onMounted, onBeforeUnmount} from 'vue';

export default{
  name: "App",
  components:{MobileHeader,DesktopHeader},
  setup(){
    onMounted(()=>{
      window.addEventListener('resize', handleResize);
    }) 
   
    
    onBeforeUnmount(()=>{
      window.removeEventListener('resize', handleResize);
    })

    const isMobile = ref(window.innerWidth <= 768)
    const handleResize = () =>{
      isMobile.value = window.innerWidth <= 768
    }
    
    return {isMobile,handleResize}
  }
}
</script>

<template>
  <MobileHeader v-if="isMobile" />
  <DesktopHeader v-else />
  <RouterView />
</template>

<style scoped>
header {
  line-height: 1.5;
  max-height: 100vh;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
  margin-top: 2rem;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }

  nav {
    text-align: left;
    margin-left: -1rem;
    font-size: 1rem;

    padding: 1rem 0;
    margin-top: 1rem;
  }
}
</style>
