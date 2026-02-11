using System;
using Canis;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.targetinformation;

namespace lib.canis.Canis.networking
{
	// Token: 0x0200001D RID: 29
	public static class TargetInformationExtensions : Object
	{
		// Token: 0x06000110 RID: 272 RVA: 0x0001D45C File Offset: 0x0001B65C
		// Note: this type is marked as 'beforefieldinit'.
		static TargetInformationExtensions()
		{
			Il2CppClassPointerStore<TargetInformationExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "lib.canis.Canis.networking", "TargetInformationExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInformationExtensions>.NativeClassPtr);
			TargetInformationExtensions.NativeMethodInfoPtr_ValidEntities_Public_Static_IEnumerable_1_T_EntityListTargetInformation_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInformationExtensions>.NativeClassPtr, 100663461);
			TargetInformationExtensions.NativeMethodInfoPtr_ToContextualString_Public_Static_String_TargetInformation_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInformationExtensions>.NativeClassPtr, 100663462);
			TargetInformationExtensions.NativeMethodInfoPtr_ToEntityString_Public_Static_String_EntityListTargetInformation_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInformationExtensions>.NativeClassPtr, 100663463);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001D4C8 File Offset: 0x0001B6C8
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 544151, RefRangeEnd = 544177, XrefRangeStart = 544137, XrefRangeEnd = 544151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> ValidEntities<T>(this EntityListTargetInformation elti, Match match) where T : Entity
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elti);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInformationExtensions.MethodInfoStoreGeneric_ValidEntities_Public_Static_IEnumerable_1_T_EntityListTargetInformation_Match_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001D520 File Offset: 0x0001B720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544177, XrefRangeEnd = 544182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToContextualString(this TargetInformation ti, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ti);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInformationExtensions.NativeMethodInfoPtr_ToContextualString_Public_Static_String_TargetInformation_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001D570 File Offset: 0x0001B770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544182, XrefRangeEnd = 544196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToEntityString(this EntityListTargetInformation elti, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elti);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInformationExtensions.NativeMethodInfoPtr_ToEntityString_Public_Static_String_EntityListTargetInformation_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002889 File Offset: 0x00000A89
		public TargetInformationExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_ValidEntities_Public_Static_IEnumerable_1_T_EntityListTargetInformation_Match_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_ToContextualString_Public_Static_String_TargetInformation_Match_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_ToEntityString_Public_Static_String_EntityListTargetInformation_Match_0;

		// Token: 0x02000244 RID: 580
		private sealed class MethodInfoStoreGeneric_ValidEntities_Public_Static_IEnumerable_1_T_EntityListTargetInformation_Match_0<T>
		{
			// Token: 0x04000FA3 RID: 4003
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TargetInformationExtensions.NativeMethodInfoPtr_ValidEntities_Public_Static_IEnumerable_1_T_EntityListTargetInformation_Match_0, Il2CppClassPointerStore<TargetInformationExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
