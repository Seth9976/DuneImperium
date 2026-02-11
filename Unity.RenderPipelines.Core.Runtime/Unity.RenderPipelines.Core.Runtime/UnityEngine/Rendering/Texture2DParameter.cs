using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200010E RID: 270
	[Serializable]
	public class Texture2DParameter : VolumeParameter<Texture>
	{
		// Token: 0x060011F6 RID: 4598 RVA: 0x0005197C File Offset: 0x0004FB7C
		// Note: this type is marked as 'beforefieldinit'.
		static Texture2DParameter()
		{
			Il2CppClassPointerStore<Texture2DParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Texture2DParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2DParameter>.NativeClassPtr);
			Texture2DParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DParameter>.NativeClassPtr, 100665922);
			Texture2DParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DParameter>.NativeClassPtr, 100665923);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x000519D4 File Offset: 0x0004FBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979072, XrefRangeEnd = 979075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DParameter(Texture value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00051A30 File Offset: 0x0004FC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979075, XrefRangeEnd = 979086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture2DParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x000094C5 File Offset: 0x000076C5
		public Texture2DParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
