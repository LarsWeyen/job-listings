<template>
  <main>
    <div class="div-space"></div>
    <FilterBox
      :tags="selectedTags"
      @tagRemove="onTagRemove"
      @tagsReset="onTagsReset"
    />
    <div>
      <div v-if="error">{{ error }}</div>
      <div>
        <JobList :jobs="filteredJobs" @tagClick="onTagClick" />
      </div>
    </div>
  </main>
</template>

<script>
import FilterBox from "./FilterBox.vue";
import JobList from "./JobList.vue";
import getJobs from "../composables/getJobs";
import { ref, watch } from "vue";
import { computed } from "@vue/reactivity";

export default {
  name: "JobListings",
  components: { FilterBox, JobList },
  setup() {
    const { jobs, error, load } = getJobs();
    const selectedTags = ref([]);

    function filterJobs(jobs, selectedTags) {
      if (!selectedTags.length) return jobs;

      const lowerCaseSelectedTags = selectedTags.map((tag) =>
        tag.toLowerCase()
      );

      return jobs.filter((job) =>
        lowerCaseSelectedTags.every((tag) =>
          job.tags.map((jobTag) => jobTag.toLowerCase()).includes(tag)
        )
      );
    }

    load();

    const filteredJobs = computed(() =>
      filterJobs(jobs.value, selectedTags.value)
    );

    const onTagClick = (tag) => {
      if (selectedTags.value.includes(tag)) {
        return;
      } else {
        selectedTags.value = [...selectedTags.value, tag];
      }
    };

    const onTagRemove = (tag) => {
      const indexToRemove = selectedTags.value.indexOf(tag);
      selectedTags.value = [
        ...selectedTags.value.filter((_, index) => index !== indexToRemove),
      ];
    };

    const onTagsReset = () => {
      selectedTags.value = [];
    };

    watch(
      selectedTags,
      () => {
        // Optional action when filtered jobs change
        console.log("Filtered jobs:", filteredJobs.value);
      },
      { deep: true }
    );

    return {
      jobs,
      error,
      onTagClick,
      selectedTags,
      filteredJobs,
      onTagRemove,
      onTagsReset,
    };
  },
};
</script>

<style scoped>
main {
  margin: 0 auto;
  width: 90%;
  display: flex;
  flex-direction: column;
}

.div-space {
  height: 120px;
}
</style>
