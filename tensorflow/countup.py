import tensorflow as tf
#cntという変数の定義
#tf.Variableは変数の働きをする（再代入可能）
#cntがカウンターの役割を果たす
cnt = tf.Variable(0,name = "cnt")
inc = tf.constant(1,name = "inc")
#カウントアップ
add_op = tf.add(cnt,inc)
#cntが
#tf.assignは定義した変数への割り当てを行う演算
#cntに再代入する演算を定義
up_op = tf.assign(cnt,add_op)

with tf.Session() as sess:
    #tf.global_variables_initializer()によって変数の初期化を行う
    sess.run(tf.global_variables_initializer())
    #カウントアップを計3回実施
    print(sess.run(up_op))
    print(sess.run(up_op))
    print(sess.run(up_op))
