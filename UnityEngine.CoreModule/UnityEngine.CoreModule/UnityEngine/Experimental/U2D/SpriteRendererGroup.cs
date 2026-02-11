using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x0200026B RID: 619
	public class SpriteRendererGroup : Object
	{
		// Token: 0x06002AFC RID: 11004 RVA: 0x000AE2A0 File Offset: 0x000AC4A0
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteRendererGroup()
		{
			Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", "SpriteRendererGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr);
			SpriteRendererGroup.AddRenderersDelegateField = IL2CPP.ResolveICall<SpriteRendererGroup.AddRenderersDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::AddRenderers");
			SpriteRendererGroup.ClearDelegateField = IL2CPP.ResolveICall<SpriteRendererGroup.ClearDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::Clear");
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00010D2C File Offset: 0x0000EF2C
		public SpriteRendererGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00010D35 File Offset: 0x0000EF35
		public static void AddRenderers(Unity.Collections.NativeArray<SpriteIntermediateRendererInfo> renderers)
		{
			SpriteRendererGroup.AddRenderers(renderers.GetUnsafeReadOnlyPtr<SpriteIntermediateRendererInfo>(), renderers.Length);
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00010D4D File Offset: 0x0000EF4D
		public unsafe static void AddRenderers(void* renderers, int count)
		{
			SpriteRendererGroup.AddRenderersDelegateField(renderers, count);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00010D5B File Offset: 0x0000EF5B
		public static void Clear()
		{
			SpriteRendererGroup.ClearDelegateField();
		}

		// Token: 0x04002587 RID: 9607
		private static readonly SpriteRendererGroup.AddRenderersDelegate AddRenderersDelegateField;

		// Token: 0x04002588 RID: 9608
		private static readonly SpriteRendererGroup.ClearDelegate ClearDelegateField;

		// Token: 0x02000A5D RID: 2653
		// (Invoke) Token: 0x06003DD7 RID: 15831
		private delegate void AddRenderersDelegate(IntPtr renderers, int count);

		// Token: 0x02000A5E RID: 2654
		// (Invoke) Token: 0x06003DD9 RID: 15833
		private delegate void ClearDelegate();
	}
}
