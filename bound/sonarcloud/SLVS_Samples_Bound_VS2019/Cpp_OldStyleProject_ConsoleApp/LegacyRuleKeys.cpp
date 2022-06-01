// Test that legacy rule keys are correctly translated.   <- cpp:S787

/*

The user settings file should contain an entry for the legacy rule key "C99CommentUsage".

Expected results:

* if the rule is "On" then there should be a "Message" issue for cpp:S787 on the first line of this file.
* if the rule is "Off" there should be no issues in this file.


Sample JSON:

Legacy key on
-> expect issue to be raised with rule key S787 showing in the Error List

{
  "sonarlint.rules": {
    "cpp:C99CommentUsage": {
      "level": "On"
    }
}


Both keys: legacy off, non-legacy on
-> expect warning in output and issue to be raised
{
  "sonarlint.rules": {
    "cpp:C99CommentUsage": {
      "level": "Off"
    },
    "cpp:S787": {
      "level": "On"
    }
  }
}

*/
