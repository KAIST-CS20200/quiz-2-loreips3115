module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let next x =
    if x%2UL = 1UL then 3UL*x+1UL
    else x/2UL
  let rec counter x ctr =
    if x = 1UL then ctr
    else counter (next x) (ctr+1)
  counter (uint64 n) 0
