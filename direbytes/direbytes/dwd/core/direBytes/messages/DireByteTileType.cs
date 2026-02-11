using System;
using boardgames.src.broadcast.motd;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.direBytes.messages
{
	// Token: 0x0200001C RID: 28
	public class DireByteTileType : Object
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00006F1C File Offset: 0x0000511C
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteTileType()
		{
			Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.messages", "DireByteTileType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr);
			DireByteTileType.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "typeName");
			DireByteTileType.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "EndTime");
			DireByteTileType.NativeFieldInfoPtr_MainTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "MainTitle");
			DireByteTileType.NativeFieldInfoPtr_MainDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "MainDescription");
			DireByteTileType.NativeFieldInfoPtr_MainImageVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "MainImageVertical");
			DireByteTileType.NativeFieldInfoPtr_MainImageHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "MainImageHorizontal");
			DireByteTileType.NativeFieldInfoPtr_MainImageRectangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "MainImageRectangle");
			DireByteTileType.NativeFieldInfoPtr_SubPageTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "SubPageTitle");
			DireByteTileType.NativeFieldInfoPtr_SubPageDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "SubPageDescription");
			DireByteTileType.NativeFieldInfoPtr_SubPageImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "SubPageImage");
			DireByteTileType.NativeFieldInfoPtr_URLButtonLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "URLButtonLink");
			DireByteTileType.NativeFieldInfoPtr_SceneLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "SceneLink");
			DireByteTileType.NativeFieldInfoPtr_PrefabName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "PrefabName");
			DireByteTileType.NativeFieldInfoPtr_SubPageTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "SubPageTemplate");
			DireByteTileType.NativeFieldInfoPtr_TimeToLive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "TimeToLive");
			DireByteTileType.NativeFieldInfoPtr_Predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, "Predicate");
			DireByteTileType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr, 100663433);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000070A0 File Offset: 0x000052A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteTileType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteTileType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002A28 File Offset: 0x00000C28
		public DireByteTileType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000070DC File Offset: 0x000052DC
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002A31 File Offset: 0x00000C31
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00007104 File Offset: 0x00005304
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002A50 File Offset: 0x00000C50
		public WargTime EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_EndTime);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_EndTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00007134 File Offset: 0x00005334
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002A7E File Offset: 0x00000C7E
		public unsafe TextBundle MainTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_MainTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_MainTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00007164 File Offset: 0x00005364
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002A9D File Offset: 0x00000C9D
		public unsafe TextBundle MainDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_MainDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_MainDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00007194 File Offset: 0x00005394
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002ABC File Offset: 0x00000CBC
		public unsafe TextBundle MainImageVertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_MainImageVertical);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_MainImageVertical), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000071C4 File Offset: 0x000053C4
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002ADB File Offset: 0x00000CDB
		public unsafe TextBundle MainImageHorizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_MainImageHorizontal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_MainImageHorizontal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000071F4 File Offset: 0x000053F4
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002AFA File Offset: 0x00000CFA
		public unsafe TextBundle MainImageRectangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_MainImageRectangle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_MainImageRectangle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00007224 File Offset: 0x00005424
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002B19 File Offset: 0x00000D19
		public unsafe TextBundle SubPageTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_SubPageTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_SubPageTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00007254 File Offset: 0x00005454
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002B38 File Offset: 0x00000D38
		public unsafe TextBundle SubPageDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_SubPageDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_SubPageDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00007284 File Offset: 0x00005484
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002B57 File Offset: 0x00000D57
		public unsafe TextBundle SubPageImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_SubPageImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_SubPageImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000072B4 File Offset: 0x000054B4
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002B76 File Offset: 0x00000D76
		public unsafe string URLButtonLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_URLButtonLink);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_URLButtonLink), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000072DC File Offset: 0x000054DC
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002B95 File Offset: 0x00000D95
		public unsafe string SceneLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_SceneLink);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_SceneLink), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00007304 File Offset: 0x00005504
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002BB4 File Offset: 0x00000DB4
		public unsafe string PrefabName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_PrefabName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_PrefabName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000732C File Offset: 0x0000552C
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002BD3 File Offset: 0x00000DD3
		public unsafe string SubPageTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_SubPageTemplate);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_SubPageTemplate), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00007354 File Offset: 0x00005554
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002BF2 File Offset: 0x00000DF2
		public WargTime TimeToLive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_TimeToLive);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_TimeToLive), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00007384 File Offset: 0x00005584
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002C20 File Offset: 0x00000E20
		public unsafe DireByteTilePredicate Predicate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_Predicate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireByteTilePredicate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileType.NativeFieldInfoPtr_Predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_MainTitle;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_MainDescription;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_MainImageVertical;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_MainImageHorizontal;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_MainImageRectangle;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_SubPageTitle;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_SubPageDescription;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_SubPageImage;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_URLButtonLink;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_SceneLink;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_PrefabName;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_SubPageTemplate;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_TimeToLive;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_Predicate;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
