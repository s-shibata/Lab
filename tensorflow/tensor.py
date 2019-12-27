import tensorflow as tf

x = tf.constant(1, name="x")
y = tf.constant(2, name="y")

add_ap = tf.add(x,y)

with tf.Session() as sess:
    print(sess.run(add_ap))
