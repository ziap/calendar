<script>
    import quotes from "$lib/json/quotes.json";

    /**@type {Date}*/
    export let date;

    /**
     * 64-bit FNV-1a hashing algorithm - Randomize the order of the quotes
     * @param {number | bigint} x - Input number
     * @returns {number} The hash value % the length of the quotes
     */
    function hash(x) {
        x = BigInt(x);
        let h = BigInt("14695981039346656037");
        for (let i = BigInt(0); i < BigInt(64); i += BigInt(8)) {
            h ^= (x >> i) & BigInt(0xff);
            h *= BigInt("1099511628211");
            h &= (BigInt(1) << BigInt(64)) - BigInt(1);
        }
        return (
            Number(
                (h & ((BigInt(1) << BigInt(32)) - BigInt(1))) ^
                    (h >> BigInt(32))
            ) % quotes.length
        );
    }

    $: quote =
        quotes[
            hash(
                ~~(
                    (date.getTime() - date.getTimezoneOffset() * 60000) /
                    1000 /
                    3600 /
                    24
                )
            )
        ];
</script>

<blockquote>
    {quote.content}
    <footer>
        &mdash; <cite>{quote.author}</cite>
    </footer>
</blockquote>

<style>
    blockquote {
        font-weight: 500;
        background-color: rgba(255, 255, 255, 0.6);
        box-shadow: 0 2px 2px 0 rgba(0, 0, 0, 0.14),
            0 3px 1px -2px rgba(0, 0, 0, 0.12), 0 1px 5px 0 rgba(0, 0, 0, 0.2);
        backdrop-filter: blur(12px);
        border-left: 4px solid #0096bf;
        margin: 1rem 2rem;
        padding: 0.5rem 1rem;
        font-style: italic;
    }

    footer {
        color: #005a73;
        text-align: right;
        padding-top: 1rem;
        font-style: normal;
        border: 0;
    }

    cite {
        font-style: normal;
    }
</style>
