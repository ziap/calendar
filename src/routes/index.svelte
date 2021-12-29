<script>
    import { onMount } from "svelte";
    import Header from "$lib/Header.svelte"
    import Solar from "$lib/Solar.svelte";
    import Lunar from "$lib/Lunar.svelte";

    /**@type {Date}*/
    let date;

    onMount(() => (date = new Date()));
</script>

<svelte:head>
    <title>Lịch vạn niên</title>
</svelte:head>

<div class="container">
    <img src="/bg.jpg" alt="background" />
    {#if date}
        <Header bind:date/> 
        <Solar {date} />
        <Lunar {date} />
    {/if}
</div>

<style>

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
