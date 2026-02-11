using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.loader.caching
{
	// Token: 0x02000185 RID: 389
	public class BaseReferenceTracker : Object
	{
		// Token: 0x06001621 RID: 5665 RVA: 0x0006D030 File Offset: 0x0006B230
		// Note: this type is marked as 'beforefieldinit'.
		static BaseReferenceTracker()
		{
			Il2CppClassPointerStore<BaseReferenceTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "BaseReferenceTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseReferenceTracker>.NativeClassPtr);
			BaseReferenceTracker.NativeFieldInfoPtr_killed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseReferenceTracker>.NativeClassPtr, "killed");
			BaseReferenceTracker.NativeFieldInfoPtr_sourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseReferenceTracker>.NativeClassPtr, "sourceName");
			BaseReferenceTracker.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceTracker>.NativeClassPtr, 100666695);
			BaseReferenceTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceTracker>.NativeClassPtr, 100666696);
			BaseReferenceTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceTracker>.NativeClassPtr, 100666697);
			BaseReferenceTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceTracker>.NativeClassPtr, 100666698);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0006D0D8 File Offset: 0x0006B2D8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseReferenceTracker(string sourceName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseReferenceTracker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseReferenceTracker.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0006D124 File Offset: 0x0006B324
		[CallerCount(0)]
		public unsafe virtual bool StillAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseReferenceTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0006D160 File Offset: 0x0006B360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878182, XrefRangeEnd = 878185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseReferenceTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0006D198 File Offset: 0x0006B398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseReferenceTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00009A8D File Offset: 0x00007C8D
		public BaseReferenceTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x0006D1CC File Offset: 0x0006B3CC
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x00009A96 File Offset: 0x00007C96
		public unsafe bool killed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseReferenceTracker.NativeFieldInfoPtr_killed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseReferenceTracker.NativeFieldInfoPtr_killed)) = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x0006D1F4 File Offset: 0x0006B3F4
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x00009AB1 File Offset: 0x00007CB1
		public unsafe string sourceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseReferenceTracker.NativeFieldInfoPtr_sourceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseReferenceTracker.NativeFieldInfoPtr_sourceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeFieldInfoPtr_killed;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeFieldInfoPtr_sourceName;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0;
	}
}
