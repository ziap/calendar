<script>
    /**@type {Date}*/
    export let date;

    const map = {
        38: -7, // Up
        39: 1, // Right
        40: 7, // Down
        37: -1, // Left
        75: -7, // Vim up
        76: 1, // Vim right
        74: 7, // Vim down
        72: -1, // Vim left
        87: -7, // W
        68: 1, // D
        83: 7, // S
        65: -1, // A
    };
</script>

<svelte:window
    on:keydown={(e) => {
        const modifiers = e.altKey || e.ctrlKey || e.metaKey || e.shiftKey;
        const mapped = map[e.keyCode];
        if (!modifiers && mapped) {
            e.preventDefault();
            date = new Date(
                date.getFullYear(),
                date.getMonth(),
                date.getDate() + mapped
            );
        }
    }}
/>
