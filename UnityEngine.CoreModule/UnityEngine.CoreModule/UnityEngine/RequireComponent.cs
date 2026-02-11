using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000125 RID: 293
	public sealed class RequireComponent : Attribute
	{
		// Token: 0x0600176E RID: 5998 RVA: 0x0006F740 File Offset: 0x0006D940
		// Note: this type is marked as 'beforefieldinit'.
		static RequireComponent()
		{
			Il2CppClassPointerStore<RequireComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RequireComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr);
			RequireComponent.NativeFieldInfoPtr_m_Type0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, "m_Type0");
			RequireComponent.NativeFieldInfoPtr_m_Type1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, "m_Type1");
			RequireComponent.NativeFieldInfoPtr_m_Type2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, "m_Type2");
			RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, 100666513);
			RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, 100666514);
			RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, 100666515);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0006F7E8 File Offset: 0x0006D9E8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequireComponent(Type requiredComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0006F834 File Offset: 0x0006DA34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442634, XrefRangeEnd = 442638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequireComponent(Type requiredComponent, Type requiredComponent2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0006F894 File Offset: 0x0006DA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660719, XrefRangeEnd = 660723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequireComponent(Type requiredComponent, Type requiredComponent2, Type requiredComponent3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x000093AD File Offset: 0x000075AD
		public RequireComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x0006F904 File Offset: 0x0006DB04
		// (set) Token: 0x06001774 RID: 6004 RVA: 0x000093B6 File Offset: 0x000075B6
		public unsafe Type m_Type0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x0006F934 File Offset: 0x0006DB34
		// (set) Token: 0x06001776 RID: 6006 RVA: 0x000093D5 File Offset: 0x000075D5
		public unsafe Type m_Type1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x0006F964 File Offset: 0x0006DB64
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x000093F4 File Offset: 0x000075F4
		public unsafe Type m_Type2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeFieldInfoPtr_m_Type0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeFieldInfoPtr_m_Type1;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeFieldInfoPtr_m_Type2;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_Type_0;
	}
}
