using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.json.events
{
	// Token: 0x0200001D RID: 29
	public class DWDEvent : Object
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x00005FD8 File Offset: 0x000041D8
		// Note: this type is marked as 'beforefieldinit'.
		static DWDEvent()
		{
			Il2CppClassPointerStore<DWDEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json.events", "DWDEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDEvent>.NativeClassPtr);
			DWDEvent.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDEvent>.NativeClassPtr, "source");
			DWDEvent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDEvent>.NativeClassPtr, 100663412);
			DWDEvent.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDEvent>.NativeClassPtr, 100663413);
			DWDEvent.NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDEvent>.NativeClassPtr, 100663414);
			DWDEvent.NativeMethodInfoPtr_CloneWithNewSource_Public_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDEvent>.NativeClassPtr, 100663415);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000606C File Offset: 0x0000426C
		[CallerCount(293)]
		[CachedScanResults(RefRangeStart = 881929, RefRangeEnd = 882222, XrefRangeStart = 881929, XrefRangeEnd = 882222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DWDEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDEvent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000060A8 File Offset: 0x000042A8
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000060F4 File Offset: 0x000042F4
		public unsafe virtual Object Source
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DWDEvent.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249606, XrefRangeEnd = 1249613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DWDEvent.NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00006144 File Offset: 0x00004344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1249617, RefRangeEnd = 1249618, XrefRangeStart = 1249613, XrefRangeEnd = 1249617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DWDEvent CloneWithNewSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDEvent.NativeMethodInfoPtr_CloneWithNewSource_Public_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DWDEvent>(intPtr3) : null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000025E6 File Offset: 0x000007E6
		public DWDEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00006184 File Offset: 0x00004384
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000025EF File Offset: 0x000007EF
		public unsafe Object source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDEvent.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDEvent.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_Object_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_Object_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_CloneWithNewSource_Public_DWDEvent_0;
	}
}
