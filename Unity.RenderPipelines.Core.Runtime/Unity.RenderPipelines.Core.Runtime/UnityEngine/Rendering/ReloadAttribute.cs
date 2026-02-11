using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000DE RID: 222
	public sealed class ReloadAttribute : Attribute
	{
		// Token: 0x06001046 RID: 4166 RVA: 0x0004B350 File Offset: 0x00049550
		// Note: this type is marked as 'beforefieldinit'.
		static ReloadAttribute()
		{
			Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ReloadAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr);
			ReloadAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr, 100665712);
			ReloadAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr, 100665713);
			ReloadAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr, 100665714);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0004B3BC File Offset: 0x000495BC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReloadAttribute(Il2CppStringArray paths, ReloadAttribute.Package package = ReloadAttribute.Package.Root)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref package;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReloadAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Package_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0004B418 File Offset: 0x00049618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977680, XrefRangeEnd = 977687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReloadAttribute(string path, ReloadAttribute.Package package = ReloadAttribute.Package.Root)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref package;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReloadAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Package_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0004B474 File Offset: 0x00049674
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, ReloadAttribute.Package package = ReloadAttribute.Package.Root)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReloadAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathFormat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangeMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangeMax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref package;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReloadAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Package_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x000089A8 File Offset: 0x00006BA8
		public ReloadAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Package_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Package_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Package_0;

		// Token: 0x02000205 RID: 517
		public enum Package
		{
			// Token: 0x040013AA RID: 5034
			Builtin,
			// Token: 0x040013AB RID: 5035
			Root,
			// Token: 0x040013AC RID: 5036
			BuiltinExtra
		}
	}
}
