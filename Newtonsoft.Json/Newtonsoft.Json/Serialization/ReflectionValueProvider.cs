using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009D RID: 157
	public class ReflectionValueProvider : Object
	{
		// Token: 0x06000D74 RID: 3444 RVA: 0x0004FF60 File Offset: 0x0004E160
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionValueProvider()
		{
			Il2CppClassPointerStore<ReflectionValueProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "ReflectionValueProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionValueProvider>.NativeClassPtr);
			ReflectionValueProvider.NativeFieldInfoPtr__memberInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionValueProvider>.NativeClassPtr, "_memberInfo");
			ReflectionValueProvider.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionValueProvider>.NativeClassPtr, 100665745);
			ReflectionValueProvider.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionValueProvider>.NativeClassPtr, 100665746);
			ReflectionValueProvider.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionValueProvider>.NativeClassPtr, 100665747);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0004FFE0 File Offset: 0x0004E1E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 753751, RefRangeEnd = 753752, XrefRangeStart = 753746, XrefRangeEnd = 753751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionValueProvider(MemberInfo memberInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionValueProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionValueProvider.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0005002C File Offset: 0x0004E22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753752, XrefRangeEnd = 753756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValue(Object target, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionValueProvider.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00050080 File Offset: 0x0004E280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753756, XrefRangeEnd = 753764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetValue(Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionValueProvider.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0000661C File Offset: 0x0000481C
		public ReflectionValueProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x000500D0 File Offset: 0x0004E2D0
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x00006625 File Offset: 0x00004825
		public unsafe MemberInfo _memberInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionValueProvider.NativeFieldInfoPtr__memberInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionValueProvider.NativeFieldInfoPtr__memberInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeFieldInfoPtr__memberInfo;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Object_Object_0;
	}
}
