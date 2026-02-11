using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.loader.caching
{
	// Token: 0x0200018F RID: 399
	public class ObjectTracker : global::Il2CppSystem.Object
	{
		// Token: 0x06001665 RID: 5733 RVA: 0x0006DCA4 File Offset: 0x0006BEA4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectTracker()
		{
			Il2CppClassPointerStore<ObjectTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "ObjectTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectTracker>.NativeClassPtr);
			ObjectTracker.NativeFieldInfoPtr_killed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTracker>.NativeClassPtr, "killed");
			ObjectTracker.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTracker>.NativeClassPtr, "obj");
			ObjectTracker.NativeFieldInfoPtr_sourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTracker>.NativeClassPtr, "sourceName");
			ObjectTracker.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTracker>.NativeClassPtr, 100666721);
			ObjectTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTracker>.NativeClassPtr, 100666722);
			ObjectTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTracker>.NativeClassPtr, 100666723);
			ObjectTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTracker>.NativeClassPtr, 100666724);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0006DD60 File Offset: 0x0006BF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectTracker(global::UnityEngine.Object obj)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectTracker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTracker.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x0006DDAC File Offset: 0x0006BFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878231, XrefRangeEnd = 878235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StillAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0006DDE8 File Offset: 0x0006BFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878235, XrefRangeEnd = 878245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0006DE20 File Offset: 0x0006C020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00009CB5 File Offset: 0x00007EB5
		public ObjectTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x0006DE54 File Offset: 0x0006C054
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x00009CBE File Offset: 0x00007EBE
		public unsafe bool killed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTracker.NativeFieldInfoPtr_killed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTracker.NativeFieldInfoPtr_killed)) = value;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x0006DE7C File Offset: 0x0006C07C
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x00009CD9 File Offset: 0x00007ED9
		public unsafe global::UnityEngine.Object obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTracker.NativeFieldInfoPtr_obj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTracker.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x0006DEAC File Offset: 0x0006C0AC
		// (set) Token: 0x06001670 RID: 5744 RVA: 0x00009CF8 File Offset: 0x00007EF8
		public unsafe string sourceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTracker.NativeFieldInfoPtr_sourceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTracker.NativeFieldInfoPtr_sourceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeFieldInfoPtr_killed;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_obj;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeFieldInfoPtr_sourceName;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0;
	}
}
