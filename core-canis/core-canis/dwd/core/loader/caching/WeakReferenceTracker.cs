using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.loader.caching
{
	// Token: 0x02000194 RID: 404
	public class WeakReferenceTracker : Object
	{
		// Token: 0x060016C6 RID: 5830 RVA: 0x0006F218 File Offset: 0x0006D418
		// Note: this type is marked as 'beforefieldinit'.
		static WeakReferenceTracker()
		{
			Il2CppClassPointerStore<WeakReferenceTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "WeakReferenceTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakReferenceTracker>.NativeClassPtr);
			WeakReferenceTracker.NativeFieldInfoPtr_killed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakReferenceTracker>.NativeClassPtr, "killed");
			WeakReferenceTracker.NativeFieldInfoPtr_sourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakReferenceTracker>.NativeClassPtr, "sourceName");
			WeakReferenceTracker.NativeFieldInfoPtr_contextReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakReferenceTracker>.NativeClassPtr, "contextReference");
			WeakReferenceTracker.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReferenceTracker>.NativeClassPtr, 100666787);
			WeakReferenceTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReferenceTracker>.NativeClassPtr, 100666788);
			WeakReferenceTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReferenceTracker>.NativeClassPtr, 100666789);
			WeakReferenceTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReferenceTracker>.NativeClassPtr, 100666790);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0006F2D4 File Offset: 0x0006D4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878467, XrefRangeEnd = 878478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReferenceTracker(Object context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReferenceTracker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReferenceTracker.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x0006F320 File Offset: 0x0006D520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878478, XrefRangeEnd = 878481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReferenceTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0006F358 File Offset: 0x0006D558
		[CallerCount(0)]
		public unsafe virtual bool StillAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReferenceTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0006F394 File Offset: 0x0006D594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReferenceTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00009FB2 File Offset: 0x000081B2
		public WeakReferenceTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x0006F3C8 File Offset: 0x0006D5C8
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x00009FBB File Offset: 0x000081BB
		public unsafe bool killed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReferenceTracker.NativeFieldInfoPtr_killed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReferenceTracker.NativeFieldInfoPtr_killed)) = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0006F3F0 File Offset: 0x0006D5F0
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x00009FD6 File Offset: 0x000081D6
		public unsafe string sourceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReferenceTracker.NativeFieldInfoPtr_sourceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReferenceTracker.NativeFieldInfoPtr_sourceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x0006F418 File Offset: 0x0006D618
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x00009FF5 File Offset: 0x000081F5
		public unsafe WeakReference contextReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReferenceTracker.NativeFieldInfoPtr_contextReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReferenceTracker.NativeFieldInfoPtr_contextReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeFieldInfoPtr_killed;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeFieldInfoPtr_sourceName;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeFieldInfoPtr_contextReference;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0;
	}
}
