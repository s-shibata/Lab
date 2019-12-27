import tensorflow as tf

#tf.constant()を使って定数を定義
x = tf.constant(1, name="x")
y = tf.constant(2, name="y")

add_ap = tf.add(x,y)

with tf.Session() as sess:
    #sess.run()にadd.opを渡すことで足し算を実行
    print(sess.run(add_ap))
