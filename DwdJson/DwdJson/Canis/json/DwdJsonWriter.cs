using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using JsonFx.Json;
using JsonFx.Serialization;

namespace Canis.json
{
	// Token: 0x02000014 RID: 20
	public sealed class DwdJsonWriter : JsonWriter
	{
		// Token: 0x0600008A RID: 138 RVA: 0x000045D0 File Offset: 0x000027D0
		// Note: this type is marked as 'beforefieldinit'.
		static DwdJsonWriter()
		{
			Il2CppClassPointerStore<DwdJsonWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "DwdJsonWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdJsonWriter>.NativeClassPtr);
			DwdJsonWriter.NativeFieldInfoPtr_modelWalker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdJsonWriter>.NativeClassPtr, "modelWalker");
			DwdJsonWriter.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonWriter>.NativeClassPtr, 100663356);
			DwdJsonWriter.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonWriter>.NativeClassPtr, 100663357);
			DwdJsonWriter.NativeMethodInfoPtr_GetWalker_Protected_Virtual_IObjectWalker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonWriter>.NativeClassPtr, 100663358);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004650 File Offset: 0x00002850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248549, XrefRangeEnd = 1248558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdJsonWriter(DataWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdJsonWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonWriter.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000469C File Offset: 0x0000289C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248558, XrefRangeEnd = 1248564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdJsonWriter(DataWriterSettings settings, [Optional] Il2CppStringArray contentTypes)
		{
			if (contentTypes == null)
			{
				contentTypes = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdJsonWriter>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonWriter.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004708 File Offset: 0x00002908
		[CallerCount(0)]
		public unsafe override IObjectWalker GetWalker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonWriter.NativeMethodInfoPtr_GetWalker_Protected_Virtual_IObjectWalker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IObjectWalker>(intPtr3) : null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002424 File Offset: 0x00000624
		public DwdJsonWriter(DataWriterSettings settings, params string[] contentTypes)
			: this(settings, new Il2CppStringArray(contentTypes))
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002433 File Offset: 0x00000633
		public DwdJsonWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004748 File Offset: 0x00002948
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000243C File Offset: 0x0000063C
		public unsafe DwdModelWalker modelWalker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdJsonWriter.NativeFieldInfoPtr_modelWalker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdModelWalker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdJsonWriter.NativeFieldInfoPtr_modelWalker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_modelWalker;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_Il2CppStringArray_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_GetWalker_Protected_Virtual_IObjectWalker_0;
	}
}
