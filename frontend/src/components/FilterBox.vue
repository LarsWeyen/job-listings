<template>
  <div class="filter-box">
    <div class="filter-tags-container">
      <ul>
        <li v-for="(tag, index) in tags" :key="index" class="job-tag">
          <span class="job-tag-text">{{ tag }}</span>
          <div class="remove-tag" @click="onTagRemoveEmitted(tag)">X</div>
        </li>
      </ul>
    </div>
    <div class="clear-container">
      <a class="clear-button" @click="onTagsResetEmitted">Clear</a>
    </div>
  </div>
</template>

<script>
export default {
  name: "FilterBox",
  props: ["tags"],
  emits: ["tagRemove"],
  setup(props, ctx) {
    const onTagRemoveEmitted = (tag) => {
      ctx.emit("tagRemove", tag);
    };

    const onTagsResetEmitted = (tag) => {
      ctx.emit("tagsReset", tag);
    };

    return { onTagRemoveEmitted, onTagsResetEmitted };
  },
};
</script>

<style scoped>
.filter-box {
  border-radius: 6px;
  -webkit-box-shadow: 7px 7px 5px 0px rgba(0, 0, 0, 0.1);
  -moz-box-shadow: 7px 7px 5px 0px rgba(0, 0, 0, 0.1);
  box-shadow: 7px 7px 5px 0px rgba(0, 0, 0, 0.1);
  width: 90%;
  background-color: #ffffff;
  min-height: 70px;
  align-self: center;

  display: grid;
  grid-template-columns: 1fr 60px;
  place-items: center;

  margin-bottom: 1.5rem;
}

ul {
  list-style: none;
  display: flex;
  flex-wrap: wrap;
  gap: 1rem;
  padding-inline: 1rem;
}

.clear-container {
  align-self: center;
}

.job-tag {
  background-color: hsl(180, 31%, 95%);
  border-radius: 4px;
  color: hsl(180, 29%, 50%);
  height: fit-content;
  font-weight: 700;
  display: flex;
  align-items: center;
}

.job-tag-text {
  padding: 6px 8px;
}

.remove-tag {
  background-color: hsl(180, 29%, 50%);
  border-radius: 0 4px 4px 0;
  padding: 8px 10px;
  color: #ffffff;
  font-weight: 700;
}
.remove-tag:hover {
  background-color: hsl(180, 14%, 20%);
  cursor: pointer;
}

.clear-button {
  font-weight: 500;
  color: hsl(180, 8%, 52%);
}

.clear-button:hover {
  text-decoration: underline;
  cursor: pointer;
  color: hsl(180, 29%, 50%);
}

@media screen and (min-width: 510px) {
  .filter-box {
    place-items: unset;
  }
  .filter-tags-container {
    align-self: start;
  }
}
</style>
