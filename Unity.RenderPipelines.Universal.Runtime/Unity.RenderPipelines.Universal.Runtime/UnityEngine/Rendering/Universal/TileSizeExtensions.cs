using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000E0 RID: 224
	public static class TileSizeExtensions : Object
	{
		// Token: 0x06001108 RID: 4360 RVA: 0x0000A242 File Offset: 0x00008442
		// Note: this type is marked as 'beforefieldinit'.
		static TileSizeExtensions()
		{
			Il2CppClassPointerStore<TileSizeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TileSizeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileSizeExtensions>.NativeClassPtr);
			TileSizeExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_TileSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileSizeExtensions>.NativeClassPtr, 100665476);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x000509C0 File Offset: 0x0004EBC0
		[CallerCount(0)]
		public unsafe static bool IsValid(this TileSize tileSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tileSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileSizeExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_TileSize_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0000A27B File Offset: 0x0000847B
		public TileSizeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_TileSize_0;
	}
}
