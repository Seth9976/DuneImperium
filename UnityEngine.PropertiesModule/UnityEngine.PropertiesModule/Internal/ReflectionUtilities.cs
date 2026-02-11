using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Properties.Internal
{
	// Token: 0x02000035 RID: 53
	public static class ReflectionUtilities : Object
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00002E4C File Offset: 0x0000104C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionUtilities()
		{
			Il2CppClassPointerStore<ReflectionUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "ReflectionUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionUtilities>.NativeClassPtr);
			ReflectionUtilities.NativeMethodInfoPtr_SanitizeMemberName_Public_Static_String_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtilities>.NativeClassPtr, 100663563);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00008284 File Offset: 0x00006484
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1233288, RefRangeEnd = 1233290, XrefRangeStart = 1233270, XrefRangeEnd = 1233288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SanitizeMemberName(MemberInfo info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtilities.NativeMethodInfoPtr_SanitizeMemberName_Public_Static_String_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002E85 File Offset: 0x00001085
		public ReflectionUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeMemberName_Public_Static_String_MemberInfo_0;
	}
}
