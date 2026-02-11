using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.ComponentModel.Design.Serialization
{
	// Token: 0x02000155 RID: 341
	public sealed class InstanceDescriptor : Object
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x0006BCD0 File Offset: 0x00069ED0
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceDescriptor()
		{
			Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design.Serialization", "InstanceDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr);
			InstanceDescriptor.NativeFieldInfoPtr__Arguments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr, "<Arguments>k__BackingField");
			InstanceDescriptor.NativeFieldInfoPtr__IsComplete_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr, "<IsComplete>k__BackingField");
			InstanceDescriptor.NativeFieldInfoPtr__MemberInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr, "<MemberInfo>k__BackingField");
			InstanceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr, 100666392);
			InstanceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_ICollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr, 100666393);
			InstanceDescriptor.NativeMethodInfoPtr_get_Arguments_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr, 100666394);
			InstanceDescriptor.NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr, 100666395);
			InstanceDescriptor.NativeMethodInfoPtr_Invoke_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr, 100666396);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0006BDA0 File Offset: 0x00069FA0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 466171, RefRangeEnd = 466180, XrefRangeStart = 466170, XrefRangeEnd = 466171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceDescriptor(MemberInfo member, ICollection arguments)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0006BE00 File Offset: 0x0006A000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 466221, RefRangeEnd = 466222, XrefRangeStart = 466180, XrefRangeEnd = 466221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isComplete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_ICollection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0006BE6C File Offset: 0x0006A06C
		public unsafe ICollection Arguments
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceDescriptor.NativeMethodInfoPtr_get_Arguments_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0006BEAC File Offset: 0x0006A0AC
		public unsafe MemberInfo MemberInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceDescriptor.NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0006BEEC File Offset: 0x0006A0EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 466243, RefRangeEnd = 466245, XrefRangeStart = 466222, XrefRangeEnd = 466243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceDescriptor.NativeMethodInfoPtr_Invoke_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00009222 File Offset: 0x00007422
		public InstanceDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0006BF2C File Offset: 0x0006A12C
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x0000922B File Offset: 0x0000742B
		public unsafe ICollection _Arguments_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceDescriptor.NativeFieldInfoPtr__Arguments_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceDescriptor.NativeFieldInfoPtr__Arguments_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0006BF5C File Offset: 0x0006A15C
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0000924A File Offset: 0x0000744A
		public unsafe bool _IsComplete_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceDescriptor.NativeFieldInfoPtr__IsComplete_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceDescriptor.NativeFieldInfoPtr__IsComplete_k__BackingField)) = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0006BF84 File Offset: 0x0006A184
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00009265 File Offset: 0x00007465
		public unsafe MemberInfo _MemberInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceDescriptor.NativeFieldInfoPtr__MemberInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceDescriptor.NativeFieldInfoPtr__MemberInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeFieldInfoPtr__Arguments_k__BackingField;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeFieldInfoPtr__IsComplete_k__BackingField;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeFieldInfoPtr__MemberInfo_k__BackingField;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_ICollection_0;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_ICollection_Boolean_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_get_Arguments_Public_get_ICollection_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Object_0;
	}
}
