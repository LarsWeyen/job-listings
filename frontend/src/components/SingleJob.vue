<template>
  <div class="job-container">
    <div class="company-image-container">
      <img v-bind:src="image" v-bind:alt="job.company" />
    </div>
    <div class="job-content">
      <div class="job-content-container">
        <span class="fw-bold job-company">{{ job.company }}</span>
        <span class="job-title fw-bold">{{ job.title }}</span>
        <div>
          <ul>
            <li>1d ago</li>
            <li>{{ job.type }}</li>
            <li>{{ job.location }}</li>
          </ul>
        </div>
      </div>
      <div class="divider"></div>
      <div class="job-tags-container">
        <div
          class="job-tag fw-bold"
          v-for="tag in job.tags"
          @click="onTagClickEmitted(tag)"
        >
          {{ tag }}
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";

export default {
  props: ["job", "tagClick"],
  emits: ["tagClick"],
  setup(props, ctx) {
    const image = computed(() => {
      return new URL("." + props.job.image, import.meta.url).href;
    });

    const onTagClickEmitted = (tag) => {
      ctx.emit("tagClick", tag);
    };

    return { image, onTagClickEmitted };
  },
};
</script>

<style scoped>
.job-container {
  border-radius: 6px;
  background-color: #ffffff;
  border-left: 5px solid hsl(180, 29%, 50%);
  position: relative;
  -webkit-box-shadow: 7px 7px 5px 0px rgba(0, 0, 0, 0.1);
  -moz-box-shadow: 7px 7px 5px 0px rgba(0, 0, 0, 0.1);
  box-shadow: 7px 7px 5px 0px rgba(0, 0, 0, 0.1);
}

.job-title:hover {
  color: hsl(180, 29%, 50%);
  cursor: pointer;
}

.job-content {
  display: flex;
  flex-direction: column;
  gap: 1rem;
  position: relative;
  top: -25px;
  padding-inline: 1.3rem;
}

.job-content-container {
  display: flex;
  flex-direction: column;

  gap: 1rem;
}

.company-image-container {
  position: relative;
  top: -25px;
  padding-left: 1.3rem;
}

.company-image-container img {
  width: 50px;
  height: 50px;
}

.divider {
  max-width: 100%;
  height: 2px;
  background-color: hsl(180, 3%, 76%);
}
.job-company {
  color: hsl(180, 29%, 50%);
}
.fw-bold {
  font-weight: 700;
}
.fw-medium {
  font-weight: 500;
}

ul {
  display: flex;
  gap: 1.5rem;
  align-items: center;
  justify-content: start;
  padding: 0;
  margin: 0;
}

ul li:first-child {
  text-decoration: none;
  list-style: none;
}

ul li {
  color: hsl(180, 8%, 52%);
  font-weight: 500;
}

.job-tags-container {
  display: flex;
  flex-wrap: wrap;
  gap: 1rem;
}
.job-tag {
  padding: 6px 8px;
  background-color: hsl(180, 31%, 95%);
  border-radius: 4px;
  color: hsl(180, 29%, 50%);
  height: fit-content;
}

.job-tag:hover {
  background-color: hsl(180, 29%, 50%);
  cursor: pointer;
  color: #ffffff;
}

@media screen and (min-width: 510px) {
  .job-content {
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
  }
}
</style>
