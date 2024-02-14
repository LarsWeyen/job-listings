<template>
  <div class="jobs-container">
    <div v-for="job in jobs" :key="job.id">
      <SingleJob :job="job" @tagClick="onTagClickEmitted" />
    </div>
  </div>
</template>

<script>
import SingleJob from "./SingleJob.vue";
export default {
  props: ["jobs", "tagClick"],
  emits: ["tagClick"],
  components: { SingleJob },

  setup(props, ctx) {
    const onTagClickEmitted = (tag) => {
      ctx.emit("tagClick", tag);
    };

    return { onTagClickEmitted };
  },
};
</script>

<style scoped>
.jobs-container {
  position: relative;
  display: flex;
  flex-direction: column;
  gap: 3rem;
  max-width: 90%;
  margin: 2rem auto 0 auto;
}
</style>
