# Word Counter

#### _Terminal Application that counts word occurances in a sentence._

#### _By **Trevor Teigen**_

## Description

This app takes a sentence and a word from the user and returns how many times that word is in the sentence, 7/26/2019.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Asks the user for a sentence** | "I walked my dog today", "dog" | string sentence = "I walked my dog today", string word = "dog"|
|This example is a short and relatively basic/common sentence structure/word choice.|
| **Checks the sentence for occurances of the word** | "Does Will Smith smith?", "smith" | int occur = 2; |
|This example is a less common than the first, being a portion of a tongue twister, but is a good example of a repeated word.|
| **Only counts words that are a full word** | "Can a woodchuck chuck wood", "wood" or "chuck" | int occur = 1; |
|Technically 'wood' and 'chuck' occur twice in this sentence but we only want to return the number standalone occurances.| 



## Setup/Installation Requirements

* Clone this repository and >dotnet run in temrinal

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#


## Support and contact details

_Please contact Trevor Teigen with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Trevor Teigen_**
