using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000325 RID: 805
	public sealed class ValueTypeFixupInfo : Object
	{
		// Token: 0x06003107 RID: 12551 RVA: 0x000F96C0 File Offset: 0x000F78C0
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeFixupInfo()
		{
			Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ValueTypeFixupInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr);
			ValueTypeFixupInfo.NativeFieldInfoPtr__containerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, "_containerID");
			ValueTypeFixupInfo.NativeFieldInfoPtr__parentField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, "_parentField");
			ValueTypeFixupInfo.NativeFieldInfoPtr__parentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, "_parentIndex");
			ValueTypeFixupInfo.NativeMethodInfoPtr__ctor_Public_Void_Int64_FieldInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671011);
			ValueTypeFixupInfo.NativeMethodInfoPtr_get_ContainerID_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671012);
			ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentField_Public_get_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671013);
			ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentIndex_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671014);
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x000F977C File Offset: 0x000F797C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1384868, RefRangeEnd = 1384871, XrefRangeStart = 1384840, XrefRangeEnd = 1384868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTypeFixupInfo(long containerID, FieldInfo member, Il2CppStructArray<int> parentIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref containerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr__ctor_Public_Void_Int64_FieldInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000F97E8 File Offset: 0x000F79E8
		public unsafe long ContainerID
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr_get_ContainerID_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x000F9824 File Offset: 0x000F7A24
		public unsafe FieldInfo ParentField
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentField_Public_get_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x000F9864 File Offset: 0x000F7A64
		public unsafe Il2CppStructArray<int> ParentIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentIndex_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x00010E3A File Offset: 0x0000F03A
		public ValueTypeFixupInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x000F98A4 File Offset: 0x000F7AA4
		// (set) Token: 0x0600310E RID: 12558 RVA: 0x00010E43 File Offset: 0x0000F043
		public unsafe long _containerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr__containerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr__containerID)) = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x000F98CC File Offset: 0x000F7ACC
		// (set) Token: 0x06003110 RID: 12560 RVA: 0x00010E5E File Offset: 0x0000F05E
		public unsafe FieldInfo _parentField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr__parentField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr__parentField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x000F98FC File Offset: 0x000F7AFC
		// (set) Token: 0x06003112 RID: 12562 RVA: 0x00010E7D File Offset: 0x0000F07D
		public unsafe Il2CppStructArray<int> _parentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr__parentIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr__parentIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002861 RID: 10337
		private static readonly IntPtr NativeFieldInfoPtr__containerID;

		// Token: 0x04002862 RID: 10338
		private static readonly IntPtr NativeFieldInfoPtr__parentField;

		// Token: 0x04002863 RID: 10339
		private static readonly IntPtr NativeFieldInfoPtr__parentIndex;

		// Token: 0x04002864 RID: 10340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_FieldInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002865 RID: 10341
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainerID_Public_get_Int64_0;

		// Token: 0x04002866 RID: 10342
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentField_Public_get_FieldInfo_0;

		// Token: 0x04002867 RID: 10343
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentIndex_Public_get_Il2CppStructArray_1_Int32_0;
	}
}
