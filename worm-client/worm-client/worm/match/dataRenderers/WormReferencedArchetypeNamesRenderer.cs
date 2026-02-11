using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.boardgames.src.match;
using lotus;
using TMPro;

namespace worm.match.dataRenderers
{
	// Token: 0x02000158 RID: 344
	public class WormReferencedArchetypeNamesRenderer : Observer
	{
		// Token: 0x06000F62 RID: 3938 RVA: 0x00046488 File Offset: 0x00044688
		// Note: this type is marked as 'beforefieldinit'.
		static WormReferencedArchetypeNamesRenderer()
		{
			Il2CppClassPointerStore<WormReferencedArchetypeNamesRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormReferencedArchetypeNamesRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormReferencedArchetypeNamesRenderer>.NativeClassPtr);
			WormReferencedArchetypeNamesRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReferencedArchetypeNamesRenderer>.NativeClassPtr, "text");
			WormReferencedArchetypeNamesRenderer.NativeFieldInfoPtr_nameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReferencedArchetypeNamesRenderer>.NativeClassPtr, "nameFormat");
			WormReferencedArchetypeNamesRenderer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReferencedArchetypeNamesRenderer>.NativeClassPtr, "archetypeProvider");
			WormReferencedArchetypeNamesRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReferencedArchetypeNamesRenderer>.NativeClassPtr, 100665377);
			WormReferencedArchetypeNamesRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReferencedArchetypeNamesRenderer>.NativeClassPtr, 100665378);
			WormReferencedArchetypeNamesRenderer.NativeMethodInfoPtr_BuildText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReferencedArchetypeNamesRenderer>.NativeClassPtr, 100665379);
			WormReferencedArchetypeNamesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReferencedArchetypeNamesRenderer>.NativeClassPtr, 100665380);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00046544 File Offset: 0x00044744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707714, XrefRangeEnd = 707719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormReferencedArchetypeNamesRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00046580 File Offset: 0x00044780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707719, XrefRangeEnd = 707721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormReferencedArchetypeNamesRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x000465BC File Offset: 0x000447BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 707764, RefRangeEnd = 707765, XrefRangeStart = 707721, XrefRangeEnd = 707764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BuildText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReferencedArchetypeNamesRenderer.NativeMethodInfoPtr_BuildText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x000465F4 File Offset: 0x000447F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707765, XrefRangeEnd = 707770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormReferencedArchetypeNamesRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormReferencedArchetypeNamesRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReferencedArchetypeNamesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0000A1D5 File Offset: 0x000083D5
		public WormReferencedArchetypeNamesRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00046630 File Offset: 0x00044830
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x0000A1DE File Offset: 0x000083DE
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReferencedArchetypeNamesRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReferencedArchetypeNamesRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00046660 File Offset: 0x00044860
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x0000A1FD File Offset: 0x000083FD
		public unsafe string nameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReferencedArchetypeNamesRenderer.NativeFieldInfoPtr_nameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReferencedArchetypeNamesRenderer.NativeFieldInfoPtr_nameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00046688 File Offset: 0x00044888
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x0000A21C File Offset: 0x0000841C
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReferencedArchetypeNamesRenderer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReferencedArchetypeNamesRenderer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_nameFormat;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_BuildText_Private_String_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
