object SumOfMultiples {
  def sum(factors: Set[Int], limit: Int): Int =
    (for {
      n <- 1 until limit
      fac <- factors
      if n % fac == 0
    } yield n).sum
}
