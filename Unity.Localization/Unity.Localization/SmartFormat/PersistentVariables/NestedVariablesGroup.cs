using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000056 RID: 86
	public class NestedVariablesGroup : Variable<VariablesGroupAsset>
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x00019FF8 File Offset: 0x000181F8
		// Note: this type is marked as 'beforefieldinit'.
		static NestedVariablesGroup()
		{
			Il2CppClassPointerStore<NestedVariablesGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "NestedVariablesGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NestedVariablesGroup>.NativeClassPtr);
			NestedVariablesGroup.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedVariablesGroup>.NativeClassPtr, 100664119);
			NestedVariablesGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedVariablesGroup>.NativeClassPtr, 100664120);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0001A050 File Offset: 0x00018250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071191, XrefRangeEnd = 1071197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(string name, out IVariable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NestedVariablesGroup.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new IVariable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0001A0C0 File Offset: 0x000182C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071197, XrefRangeEnd = 1071200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NestedVariablesGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NestedVariablesGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NestedVariablesGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00003B22 File Offset: 0x00001D22
		public NestedVariablesGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
