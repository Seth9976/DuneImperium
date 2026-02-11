using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000021 RID: 33
	public sealed class HumanBone : ValueType
	{
		// Token: 0x0600026D RID: 621 RVA: 0x0000F72C File Offset: 0x0000D92C
		// Note: this type is marked as 'beforefieldinit'.
		static HumanBone()
		{
			Il2CppClassPointerStore<HumanBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanBone>.NativeClassPtr);
			HumanBone.NativeFieldInfoPtr_m_BoneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "m_BoneName");
			HumanBone.NativeFieldInfoPtr_m_HumanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "m_HumanName");
			HumanBone.NativeFieldInfoPtr_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "limit");
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000271C File Offset: 0x0000091C
		public HumanBone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002725 File Offset: 0x00000925
		public HumanBone()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HumanBone>.NativeClassPtr))
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000F798 File Offset: 0x0000D998
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002737 File Offset: 0x00000937
		public unsafe string m_BoneName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_BoneName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_BoneName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002756 File Offset: 0x00000956
		public unsafe string m_HumanName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_HumanName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_HumanName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000F7E8 File Offset: 0x0000D9E8
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00002775 File Offset: 0x00000975
		public unsafe HumanLimit limit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_limit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_limit)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000F810 File Offset: 0x0000DA10
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00002790 File Offset: 0x00000990
		public string boneName
		{
			get
			{
				return this.m_BoneName;
			}
			set
			{
				this.m_BoneName = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000F828 File Offset: 0x0000DA28
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0000279A File Offset: 0x0000099A
		public string humanName
		{
			get
			{
				return this.m_HumanName;
			}
			set
			{
				this.m_HumanName = value;
			}
		}

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneName;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_m_HumanName;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_limit;
	}
}
