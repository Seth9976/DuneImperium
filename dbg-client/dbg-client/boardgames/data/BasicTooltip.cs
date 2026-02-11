using System;
using System.Runtime.InteropServices;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.data
{
	// Token: 0x0200017E RID: 382
	public class BasicTooltip : VersionedDataComponent
	{
		// Token: 0x060010C4 RID: 4292 RVA: 0x00052854 File Offset: 0x00050A54
		// Note: this type is marked as 'beforefieldinit'.
		static BasicTooltip()
		{
			Il2CppClassPointerStore<BasicTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "BasicTooltip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicTooltip>.NativeClassPtr);
			BasicTooltip.NativeFieldInfoPtr_tooltipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicTooltip>.NativeClassPtr, "tooltipName");
			BasicTooltip.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicTooltip>.NativeClassPtr, "args");
			BasicTooltip.NativeMethodInfoPtr_get_TooltipName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTooltip>.NativeClassPtr, 100665649);
			BasicTooltip.NativeMethodInfoPtr_get_Args_Public_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTooltip>.NativeClassPtr, 100665650);
			BasicTooltip.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTooltip>.NativeClassPtr, 100665651);
			BasicTooltip.NativeMethodInfoPtr_SetTooltip_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTooltip>.NativeClassPtr, 100665652);
			BasicTooltip.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTooltip>.NativeClassPtr, 100665653);
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00052910 File Offset: 0x00050B10
		public unsafe string TooltipName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTooltip.NativeMethodInfoPtr_get_TooltipName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x00052948 File Offset: 0x00050B48
		public unsafe Il2CppReferenceArray<Object> Args
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTooltip.NativeMethodInfoPtr_get_Args_Public_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00052988 File Offset: 0x00050B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514309, XrefRangeEnd = 514315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicTooltip(string tooltipName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicTooltip>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltipName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTooltip.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x000529F4 File Offset: 0x00050BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 514318, RefRangeEnd = 514319, XrefRangeStart = 514315, XrefRangeEnd = 514318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTooltip(string tooltipName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltipName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTooltip.NativeMethodInfoPtr_SetTooltip_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00052A58 File Offset: 0x00050C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514319, XrefRangeEnd = 514330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicTooltip.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0000A166 File Offset: 0x00008366
		public BasicTooltip(string tooltipName, params Object[] args)
			: this(tooltipName, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0000A175 File Offset: 0x00008375
		public void SetTooltip(string tooltipName, params Object[] args)
		{
			this.SetTooltip(tooltipName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0000A184 File Offset: 0x00008384
		public BasicTooltip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x00052A9C File Offset: 0x00050C9C
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0000A18D File Offset: 0x0000838D
		public unsafe string tooltipName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTooltip.NativeFieldInfoPtr_tooltipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTooltip.NativeFieldInfoPtr_tooltipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x00052AC4 File Offset: 0x00050CC4
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x0000A1AC File Offset: 0x000083AC
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTooltip.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTooltip.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr_tooltipName;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_get_TooltipName_Public_get_String_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_SetTooltip_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
