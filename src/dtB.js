const MixedArray = [
    true,
    14,
    88,
    "fff",
    -44,
    null,
    3.14,
    false,
    [1, 2, 3],
    "",
    "jsjsjsjs",
    0,
    {x: 22, y: 44},
]

let ItemTypeHash = {};

for (const item of MixedArray) {
    const type = typeof item
    if (!ItemTypeHash.hasOwnProperty(type)) {
        ItemTypeHash[type] = 0;
    }
    ItemTypeHash[type]++
}


console.log(ItemTypeHash);