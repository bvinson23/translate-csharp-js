// Put your code here

const names = [
    "Nashville", "Hong Kong", "The back yard", "Earth",
    "London", "The mall", "Ryman Auditorium", "The Great Wall of China"
];

console.log("All Place Names");

for (placeName of names) {
    console.log(placeName)
}

console.log("\n");

const theNames = names.filter(n => n.startsWith("The"));

console.log("'The' Place Names");
for (placeName of theNames) {
    console.log(placeName);
}