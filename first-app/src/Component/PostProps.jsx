import React from 'react'

const PostProps = (props) => {
    const {userId, id, title, body} = props;
    const {post} = props
   
  return (
    <>
     {userId.map((data)=>{
        return(
            <div>
                <ul>
                    <li>{data.userId}</li>
                    <li>{data.id}</li>
                    <li>{data.title}</li>
                    <li>{data.body}</li>
                </ul>
            </div>
        )
     })}
    </>
  )
}

export default PostProps
