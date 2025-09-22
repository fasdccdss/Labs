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

let ItemTypeHash = {number: 0, string: 0, boolean: 0, null: 0, undefined: 0};

for (const item of MixedArray) {
    const type = typeof item
    if (ItemTypeHash.hasOwnProperty(type)) {
        ItemTypeHash[type]++;
    }
}


console.log(ItemTypeHash);