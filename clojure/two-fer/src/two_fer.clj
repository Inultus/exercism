(ns two-fer)

(defn two-fer
  ([] "One for you, one for me.")
  ([name] (str "One for " name ", one for me."))
)

#_ (defn two-fer [& [recipient]]
     (format "One for %s, one for me." (or recipient "you")))

#_ (defn two-fer
     ([] (two-fer "you"))
     ([name] (str "One for " name ", one for me.")))

#_ (defn two-fer
     ([] (two-fer "you"))
     ([name] (format "One for %s, one for me." name)))