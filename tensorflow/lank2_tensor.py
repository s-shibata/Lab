import tensorflow as tf

#ランク2のテンソルの定義
x = tf.constant([[1,2],[1,2]],tf.int32,name="x")
y = tf.constant([[3,4],[3,4]],tf.int32,name="y")

add_op = tf.add(x,y)

with tf.Session() as sess:
    #行列の足し算
    print(sess.run(add_op))
