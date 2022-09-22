EXPANDED FRONTEND TECHNICAL TEST

We would like you to create a page that features some information cards and a leaderboard for an internal Scrabble tournament using Angular. We expect to see the page broken into smaller, reusable components.
A desktop design for the page can be found here: https://www.figma.com/file/N4TDVJkWRYTSNP045We626/FE-UX-Test

You will need to decide how to make the page responsive so that it works on mobile screen sizes. Use your best judgement to decide when breakpoints need adding and how the content needs to respond.
You should utilise Git to keep track of changes, and regular commits should be made to ensure a robust version history. Please let us know your GitHub, and we will create a repository for you to upload.
You should create a model that represents something akin to the following JSON as a schema and persist/retrieve results in/from a database with accessed via a C# web API.



Similarly, based on the following, JSON should have a schema for players also maintainable via API calls. This data should be used to identify the player with their corresponding score.




We expect you to use an Angular Material Table component for displaying the data. The players in 1st, 2nd and 3rd places should have a trophy displayed against their position, and each column in the table should be sortable. Should be able to search the players by name. Each row in the players' table should also have a data attribute named “player”, with the value consisting of the player’s name, score, and index they are within the array. Add jasmine unit tests for the component methods.


