using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.U2D
{
	// Token: 0x02000313 RID: 787
	public static class SpriteRendererDataAccessExtensions
	{
		// Token: 0x06002DE8 RID: 11752 RVA: 0x000B463C File Offset: 0x000B283C
		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<byte> src)
		{
			bool flag = spriteRenderer.sprite == null;
			if (flag)
			{
				throw new ArgumentException(String.Format("spriteRenderer does not have a valid sprite set.", Array.Empty<Object>()));
			}
			bool flag2 = src.Length != SpriteDataAccessExtensions.GetPrimaryVertexStreamSize(spriteRenderer.sprite);
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("custom sprite vertex data size must match sprite asset's vertex data size {0} {1}", src.Length, SpriteDataAccessExtensions.GetPrimaryVertexStreamSize(spriteRenderer.sprite)));
			}
			SpriteRendererDataAccessExtensions.SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr<byte>(), src.Length);
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x000B46CC File Offset: 0x000B28CC
		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<Vector3> src)
		{
			bool flag = spriteRenderer.sprite == null;
			if (flag)
			{
				throw new InvalidOperationException("spriteRenderer does not have a valid sprite set.");
			}
			bool flag2 = src.Length != SpriteDataAccessExtensions.GetVertexCount(spriteRenderer.sprite);
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("The src length {0} must match the vertex count of source Sprite {1}.", src.Length, SpriteDataAccessExtensions.GetVertexCount(spriteRenderer.sprite)));
			}
			SpriteRendererDataAccessExtensions.SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr<Vector3>(), src.Length);
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x000B4750 File Offset: 0x000B2950
		public static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, Unity.Collections.NativeArray<IntPtr> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<Bounds> bounds)
		{
			int num = spriteRenderers.Length;
			bool flag = num != buffers.Length || num != bufferSizes.Length || num != bounds.Length;
			if (flag)
			{
				throw new ArgumentException("Input array sizes are not the same.");
			}
			SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArray(spriteRenderers, buffers.GetUnsafeReadOnlyPtr<IntPtr>(), bufferSizes.GetUnsafeReadOnlyPtr<int>(), bounds.GetUnsafeReadOnlyPtr<Bounds>(), num);
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000B47B4 File Offset: 0x000B29B4
		public unsafe static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, IntPtr buffer)
		{
			return SpriteRendererDataAccessExtensions.IsUsingDeformableBuffer(spriteRenderer, (void*)buffer);
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x000124BB File Offset: 0x000106BB
		public static void DeactivateDeformableBuffer(SpriteRenderer renderer)
		{
			SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x000124CD File Offset: 0x000106CD
		public static void SetLocalAABB(SpriteRenderer renderer, Bounds aabb)
		{
			SpriteRendererDataAccessExtensions.SetLocalAABB_Injected(renderer, ref aabb);
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x000124D7 File Offset: 0x000106D7
		public unsafe static void SetDeformableBuffer(SpriteRenderer spriteRenderer, void* src, int count)
		{
			SpriteRendererDataAccessExtensions.SetDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer), src, count);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x000124EB File Offset: 0x000106EB
		public unsafe static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, void* buffers, void* bufferSizes, void* bounds, int count)
		{
			SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderers), buffers, bufferSizes, bounds, count);
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x00012502 File Offset: 0x00010702
		public unsafe static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, void* buffer)
		{
			return SpriteRendererDataAccessExtensions.IsUsingDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer), buffer);
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x00012515 File Offset: 0x00010715
		public static void SetLocalAABB_Injected(SpriteRenderer renderer, ref Bounds aabb)
		{
			SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer), ref aabb);
		}

		// Token: 0x04002964 RID: 10596
		private static readonly SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegate DeactivateDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::DeactivateDeformableBuffer");

		// Token: 0x04002965 RID: 10597
		private static readonly SpriteRendererDataAccessExtensions.SetDeformableBufferDelegate SetDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetDeformableBuffer");

		// Token: 0x04002966 RID: 10598
		private static readonly SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegate SetBatchDeformableBufferAndLocalAABBArrayDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetBatchDeformableBufferAndLocalAABBArray");

		// Token: 0x04002967 RID: 10599
		private static readonly SpriteRendererDataAccessExtensions.IsUsingDeformableBufferDelegate IsUsingDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.IsUsingDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::IsUsingDeformableBuffer");

		// Token: 0x04002968 RID: 10600
		private static readonly SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegate SetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetLocalAABB_Injected");

		// Token: 0x02000B70 RID: 2928
		// (Invoke) Token: 0x06003FD5 RID: 16341
		private delegate void DeactivateDeformableBufferDelegate(IntPtr renderer);

		// Token: 0x02000B71 RID: 2929
		// (Invoke) Token: 0x06003FD7 RID: 16343
		private delegate void SetDeformableBufferDelegate(IntPtr spriteRenderer, IntPtr src, int count);

		// Token: 0x02000B72 RID: 2930
		// (Invoke) Token: 0x06003FD9 RID: 16345
		private delegate void SetBatchDeformableBufferAndLocalAABBArrayDelegate(IntPtr spriteRenderers, IntPtr buffers, IntPtr bufferSizes, IntPtr bounds, int count);

		// Token: 0x02000B73 RID: 2931
		// (Invoke) Token: 0x06003FDB RID: 16347
		private delegate bool IsUsingDeformableBufferDelegate(IntPtr spriteRenderer, IntPtr buffer);

		// Token: 0x02000B74 RID: 2932
		// (Invoke) Token: 0x06003FDD RID: 16349
		private delegate void SetLocalAABB_InjectedDelegate(IntPtr renderer, IntPtr aabb);
	}
}
