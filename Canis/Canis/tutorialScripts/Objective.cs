using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.tutorialScripts
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	public class Objective : Object
	{
		// Token: 0x0600039E RID: 926 RVA: 0x0002811C File Offset: 0x0002631C
		// Note: this type is marked as 'beforefieldinit'.
		static Objective()
		{
			Il2CppClassPointerStore<Objective>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.tutorialScripts", "Objective");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Objective>.NativeClassPtr);
			Objective.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Objective>.NativeClassPtr, "id");
			Objective.NativeFieldInfoPtr_locStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Objective>.NativeClassPtr, "locStr");
			Objective.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Objective>.NativeClassPtr, "current");
			Objective.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Objective>.NativeClassPtr, "max");
			Objective.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Objective>.NativeClassPtr, 100664107);
			Objective.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Objective>.NativeClassPtr, 100664108);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000281C4 File Offset: 0x000263C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551392, XrefRangeEnd = 551413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Objective.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00028208 File Offset: 0x00026408
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Objective()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Objective>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Objective.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000038F7 File Offset: 0x00001AF7
		public Objective(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00028244 File Offset: 0x00026444
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003900 File Offset: 0x00001B00
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Objective.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Objective.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0002826C File Offset: 0x0002646C
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0000391B File Offset: 0x00001B1B
		public unsafe string locStr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Objective.NativeFieldInfoPtr_locStr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Objective.NativeFieldInfoPtr_locStr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00028294 File Offset: 0x00026494
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0000393A File Offset: 0x00001B3A
		public unsafe int current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Objective.NativeFieldInfoPtr_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Objective.NativeFieldInfoPtr_current)) = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x000282BC File Offset: 0x000264BC
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00003955 File Offset: 0x00001B55
		public unsafe int max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Objective.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Objective.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_locStr;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
