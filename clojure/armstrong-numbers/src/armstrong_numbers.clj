(ns armstrong-numbers)

(defn number-to-digits [num]
  (map #(Character/digit % 10) (str num)))

(defn sum-of-digits [num]
  (let [digits (number-to-digits num)]
    (reduce + (map bigint (map #(Math/pow % (count digits)) digits)))))

(defn armstrong? [num]
  (= num (sum-of-digits num)))
