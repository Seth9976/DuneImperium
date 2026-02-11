using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000065 RID: 101
	public class MemberBinding : Object
	{
		// Token: 0x06000596 RID: 1430 RVA: 0x0002B4A0 File Offset: 0x000296A0
		// Note: this type is marked as 'beforefieldinit'.
		static MemberBinding()
		{
			Il2CppClassPointerStore<MemberBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MemberBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberBinding>.NativeClassPtr);
			MemberBinding.NativeFieldInfoPtr__BindingType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberBinding>.NativeClassPtr, "<BindingType>k__BackingField");
			MemberBinding.NativeFieldInfoPtr__Member_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberBinding>.NativeClassPtr, "<Member>k__BackingField");
			MemberBinding.NativeMethodInfoPtr_get_BindingType_Public_get_MemberBindingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberBinding>.NativeClassPtr, 100664506);
			MemberBinding.NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberBinding>.NativeClassPtr, 100664507);
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0002B520 File Offset: 0x00029720
		public unsafe MemberBindingType BindingType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberBinding.NativeMethodInfoPtr_get_BindingType_Public_get_MemberBindingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0002B55C File Offset: 0x0002975C
		public unsafe MemberInfo Member
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberBinding.NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000034FB File Offset: 0x000016FB
		public MemberBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0002B59C File Offset: 0x0002979C
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00003504 File Offset: 0x00001704
		public unsafe MemberBindingType _BindingType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberBinding.NativeFieldInfoPtr__BindingType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberBinding.NativeFieldInfoPtr__BindingType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0002B5C4 File Offset: 0x000297C4
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x0000351F File Offset: 0x0000171F
		public unsafe MemberInfo _Member_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberBinding.NativeFieldInfoPtr__Member_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberBinding.NativeFieldInfoPtr__Member_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr__BindingType_k__BackingField;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr__Member_k__BackingField;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_get_BindingType_Public_get_MemberBindingType_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0;
	}
}
