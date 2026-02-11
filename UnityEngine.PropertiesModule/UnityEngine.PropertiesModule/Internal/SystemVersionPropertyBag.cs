using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Properties.Internal
{
	// Token: 0x0200002F RID: 47
	public class SystemVersionPropertyBag : ContainerPropertyBag<Version>
	{
		// Token: 0x0600016A RID: 362 RVA: 0x00002BCC File Offset: 0x00000DCC
		// Note: this type is marked as 'beforefieldinit'.
		static SystemVersionPropertyBag()
		{
			Il2CppClassPointerStore<SystemVersionPropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "SystemVersionPropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemVersionPropertyBag>.NativeClassPtr);
			SystemVersionPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemVersionPropertyBag>.NativeClassPtr, 100663518);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007598 File Offset: 0x00005798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232586, RefRangeEnd = 1232587, XrefRangeStart = 1232519, XrefRangeEnd = 1232586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemVersionPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemVersionPropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemVersionPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002C05 File Offset: 0x00000E05
		public SystemVersionPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000099 RID: 153
		public class MajorProperty : Property<Version, int>
		{
			// Token: 0x060002D3 RID: 723 RVA: 0x0000BAE8 File Offset: 0x00009CE8
			// Note: this type is marked as 'beforefieldinit'.
			static MajorProperty()
			{
				Il2CppClassPointerStore<SystemVersionPropertyBag.MajorProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SystemVersionPropertyBag>.NativeClassPtr, "MajorProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemVersionPropertyBag.MajorProperty>.NativeClassPtr);
				SystemVersionPropertyBag.MajorProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemVersionPropertyBag.MajorProperty>.NativeClassPtr, 100663519);
				SystemVersionPropertyBag.MajorProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemVersionPropertyBag.MajorProperty>.NativeClassPtr, 100663520);
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x0000BB3C File Offset: 0x00009D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232471, XrefRangeEnd = 1232481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MajorProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemVersionPropertyBag.MajorProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemVersionPropertyBag.MajorProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000BB78 File Offset: 0x00009D78
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232481, XrefRangeEnd = 1232483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SystemVersionPropertyBag.MajorProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x000033C6 File Offset: 0x000015C6
			public MajorProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000165 RID: 357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000166 RID: 358
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
		}

		// Token: 0x0200009A RID: 154
		public class MinorProperty : Property<Version, int>
		{
			// Token: 0x060002D7 RID: 727 RVA: 0x0000BBBC File Offset: 0x00009DBC
			// Note: this type is marked as 'beforefieldinit'.
			static MinorProperty()
			{
				Il2CppClassPointerStore<SystemVersionPropertyBag.MinorProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SystemVersionPropertyBag>.NativeClassPtr, "MinorProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemVersionPropertyBag.MinorProperty>.NativeClassPtr);
				SystemVersionPropertyBag.MinorProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemVersionPropertyBag.MinorProperty>.NativeClassPtr, 100663521);
				SystemVersionPropertyBag.MinorProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemVersionPropertyBag.MinorProperty>.NativeClassPtr, 100663522);
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x0000BC10 File Offset: 0x00009E10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232483, XrefRangeEnd = 1232493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MinorProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemVersionPropertyBag.MinorProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemVersionPropertyBag.MinorProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000BC4C File Offset: 0x00009E4C
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232493, XrefRangeEnd = 1232495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SystemVersionPropertyBag.MinorProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002DA RID: 730 RVA: 0x000033CF File Offset: 0x000015CF
			public MinorProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000167 RID: 359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000168 RID: 360
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
		}

		// Token: 0x0200009B RID: 155
		public class BuildProperty : Property<Version, int>
		{
			// Token: 0x060002DB RID: 731 RVA: 0x0000BC90 File Offset: 0x00009E90
			// Note: this type is marked as 'beforefieldinit'.
			static BuildProperty()
			{
				Il2CppClassPointerStore<SystemVersionPropertyBag.BuildProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SystemVersionPropertyBag>.NativeClassPtr, "BuildProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemVersionPropertyBag.BuildProperty>.NativeClassPtr);
				SystemVersionPropertyBag.BuildProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemVersionPropertyBag.BuildProperty>.NativeClassPtr, 100663523);
				SystemVersionPropertyBag.BuildProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemVersionPropertyBag.BuildProperty>.NativeClassPtr, 100663524);
			}

			// Token: 0x060002DC RID: 732 RVA: 0x0000BCE4 File Offset: 0x00009EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232495, XrefRangeEnd = 1232505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BuildProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemVersionPropertyBag.BuildProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemVersionPropertyBag.BuildProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060002DD RID: 733 RVA: 0x0000BD20 File Offset: 0x00009F20
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232505, XrefRangeEnd = 1232507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SystemVersionPropertyBag.BuildProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002DE RID: 734 RVA: 0x000033D8 File Offset: 0x000015D8
			public BuildProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000169 RID: 361
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400016A RID: 362
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
		}

		// Token: 0x0200009C RID: 156
		public class RevisionProperty : Property<Version, int>
		{
			// Token: 0x060002DF RID: 735 RVA: 0x0000BD64 File Offset: 0x00009F64
			// Note: this type is marked as 'beforefieldinit'.
			static RevisionProperty()
			{
				Il2CppClassPointerStore<SystemVersionPropertyBag.RevisionProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SystemVersionPropertyBag>.NativeClassPtr, "RevisionProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemVersionPropertyBag.RevisionProperty>.NativeClassPtr);
				SystemVersionPropertyBag.RevisionProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemVersionPropertyBag.RevisionProperty>.NativeClassPtr, 100663525);
				SystemVersionPropertyBag.RevisionProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemVersionPropertyBag.RevisionProperty>.NativeClassPtr, 100663526);
			}

			// Token: 0x060002E0 RID: 736 RVA: 0x0000BDB8 File Offset: 0x00009FB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232507, XrefRangeEnd = 1232517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RevisionProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemVersionPropertyBag.RevisionProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemVersionPropertyBag.RevisionProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000BDF4 File Offset: 0x00009FF4
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232517, XrefRangeEnd = 1232519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SystemVersionPropertyBag.RevisionProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x000033E1 File Offset: 0x000015E1
			public RevisionProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400016B RID: 363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400016C RID: 364
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
		}
	}
}
