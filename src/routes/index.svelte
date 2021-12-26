<script>
    import { onMount } from "svelte";
    import Solar from "$lib/Solar.svelte";
    import Lunar from "$lib/Lunar.svelte";

    /**@type {Date}*/
    let date;

    onMount(() => (date = new Date()));
</script>

<svelte:head>
    {#if date}
        <title
            >{date.toLocaleString("vi-VN", {
                weekday: "long",
                year: "numeric",
                month: "long",
                day: "numeric",
            }) + " | Lịch vạn niên"}</title
        >
    {/if}
</svelte:head>
<div class="container">
    <img src="/bg.jpg" alt="background" />
    {#if date}
        <Solar {date} />
        <Lunar {date} />
    {/if}
</div>

<style>
    * {
        font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto,
            Oxygen, Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
    }

    .container {
        position: absolute;
        display: flex;
        flex-direction: column;
        justify-content: space-between;
        inset: 0;
        overflow: hidden;
    }

    img {
        z-index: -1;
        position: absolute;
        inset: 0;
        width: 100%;
        height: 100%;
        object-fit: cover;
    }
</style>
