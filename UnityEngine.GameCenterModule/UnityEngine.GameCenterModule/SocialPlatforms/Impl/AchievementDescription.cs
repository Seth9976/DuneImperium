using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200000C RID: 12
	public class AchievementDescription : Object
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00003E50 File Offset: 0x00002050
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementDescription()
		{
			Il2CppClassPointerStore<AchievementDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine.SocialPlatforms.Impl", "AchievementDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementDescription>.NativeClassPtr);
			AchievementDescription.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementDescription>.NativeClassPtr, "<id>k__BackingField");
			AchievementDescription.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementDescription>.NativeClassPtr, 100663333);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003EA8 File Offset: 0x000020A8
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000252A File Offset: 0x0000072A
		public unsafe virtual string id
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementDescription.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this._id_k__BackingField = value;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000024E8 File Offset: 0x000006E8
		public AchievementDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003EE0 File Offset: 0x000020E0
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000024F1 File Offset: 0x000006F1
		public unsafe string _id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementDescription.NativeFieldInfoPtr__id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementDescription.NativeFieldInfoPtr__id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002510 File Offset: 0x00000710
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000251D File Offset: 0x0000071D
		public void SetImage(Texture2D image)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002533 File Offset: 0x00000733
		public string title
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002540 File Offset: 0x00000740
		public Texture2D image
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000254D File Offset: 0x0000074D
		public string achievedDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000255A File Offset: 0x0000075A
		public string unachievedDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002567 File Offset: 0x00000767
		public bool hidden
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002574 File Offset: 0x00000774
		public int points
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;
	}
}
