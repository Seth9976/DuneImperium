using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.direBytes.messages
{
	// Token: 0x0200001B RID: 27
	public class DireByteTileProperties : global::Il2CppSystem.Object
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00006CE8 File Offset: 0x00004EE8
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteTileProperties()
		{
			Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.messages", "DireByteTileProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr);
			DireByteTileProperties.NativeFieldInfoPtr_Project = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr, "Project");
			DireByteTileProperties.NativeFieldInfoPtr_Domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr, "Domain");
			DireByteTileProperties.NativeFieldInfoPtr_InternalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr, "InternalName");
			DireByteTileProperties.NativeFieldInfoPtr_Layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr, "Layout");
			DireByteTileProperties.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr, "Priority");
			DireByteTileProperties.NativeFieldInfoPtr_Platforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr, "Platforms");
			DireByteTileProperties.NativeFieldInfoPtr_TileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr, "TileType");
			DireByteTileProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr, 100663432);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006DB8 File Offset: 0x00004FB8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteTileProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteTileProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000294A File Offset: 0x00000B4A
		public DireByteTileProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00006DF4 File Offset: 0x00004FF4
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002953 File Offset: 0x00000B53
		public unsafe string Project
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_Project);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_Project), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00006E1C File Offset: 0x0000501C
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002972 File Offset: 0x00000B72
		public unsafe string Domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_Domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_Domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00006E44 File Offset: 0x00005044
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002991 File Offset: 0x00000B91
		public unsafe string InternalName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_InternalName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_InternalName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00006E6C File Offset: 0x0000506C
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000029B0 File Offset: 0x00000BB0
		public unsafe string Layout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_Layout);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_Layout), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00006E94 File Offset: 0x00005094
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000029CF File Offset: 0x00000BCF
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00006EBC File Offset: 0x000050BC
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000029EA File Offset: 0x00000BEA
		public unsafe List<RuntimePlatform> Platforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_Platforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuntimePlatform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_Platforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00006EEC File Offset: 0x000050EC
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002A09 File Offset: 0x00000C09
		public unsafe DireByteTileType TileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_TileType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireByteTileType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileProperties.NativeFieldInfoPtr_TileType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_Project;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_Domain;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_InternalName;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_Layout;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_Platforms;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_TileType;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
