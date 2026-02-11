using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.messages.outgoing;

namespace Canis.context
{
	// Token: 0x02000117 RID: 279
	public class Context : Object
	{
		// Token: 0x06000C9D RID: 3229 RVA: 0x0004FC58 File Offset: 0x0004DE58
		// Note: this type is marked as 'beforefieldinit'.
		static Context()
		{
			Il2CppClassPointerStore<Context>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context", "Context");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Context>.NativeClassPtr);
			Context.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "target");
			Context.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "Source");
			Context.NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "parameters");
			Context.NativeMethodInfoPtr_get_Target_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666198);
			Context.NativeMethodInfoPtr_get_Parameters_Public_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666199);
			Context.NativeMethodInfoPtr__ctor_Public_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666200);
			Context.NativeMethodInfoPtr_Where_Public_Context_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666201);
			Context.NativeMethodInfoPtr__ctor_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666202);
			Context.NativeMethodInfoPtr__ctor_Public_Void_Entity_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666203);
			Context.NativeMethodInfoPtr__ctor_Public_Void_Context_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666204);
			Context.NativeMethodInfoPtr_CopyParameters_Public_Context_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666205);
			Context.NativeMethodInfoPtr_CopyParameters_Public_Context_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666206);
			Context.NativeMethodInfoPtr_GetTargets_Public_List_1_T_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666207);
			Context.NativeMethodInfoPtr_TargetIs_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666208);
			Context.NativeMethodInfoPtr_GetTarget_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666209);
			Context.NativeMethodInfoPtr_TryGetTarget_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666210);
			Context.NativeMethodInfoPtr_GetTargetEntity_Public_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666211);
			Context.NativeMethodInfoPtr_GetFirstSelection_Public_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666212);
			Context.NativeMethodInfoPtr_WithTarget_Public_Context_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666213);
			Context.NativeMethodInfoPtr_WithParameter_Public_Context_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666214);
			Context.NativeMethodInfoPtr_Serialized_Public_SerializedContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666215);
			Context.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666216);
			Context.NativeMethodInfoPtr_Calcified_Public_Static_String_Object_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666217);
			Context.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityID_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666218);
			Context.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityIDTargetResponses_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666219);
			Context.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityIDEntityTargetsResponse_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100666220);
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0004FE90 File Offset: 0x0004E090
		public unsafe Entity Target
		{
			[CallerCount(311)]
			[CachedScanResults(RefRangeStart = 574243, RefRangeEnd = 574554, XrefRangeStart = 574240, XrefRangeEnd = 574243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_Target_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0004FED0 File Offset: 0x0004E0D0
		public unsafe Dictionary<string, Object> Parameters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_Parameters_Public_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0004FF10 File Offset: 0x0004E110
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 574572, RefRangeEnd = 574591, XrefRangeStart = 574554, XrefRangeEnd = 574572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context(Context context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Context>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr__ctor_Public_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0004FF5C File Offset: 0x0004E15C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 574598, RefRangeEnd = 574599, XrefRangeStart = 574591, XrefRangeEnd = 574598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context Where(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_Where_Public_Context_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0004FFC0 File Offset: 0x0004E1C0
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 574615, RefRangeEnd = 574698, XrefRangeStart = 574599, XrefRangeEnd = 574615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context(Entity source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Context>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr__ctor_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0005000C File Offset: 0x0004E20C
		[CallerCount(68)]
		[CachedScanResults(RefRangeStart = 574720, RefRangeEnd = 574788, XrefRangeStart = 574698, XrefRangeEnd = 574720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context(Entity source, Object target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Context>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr__ctor_Public_Void_Entity_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0005006C File Offset: 0x0004E26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574788, XrefRangeEnd = 574806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context(Context context, Object target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Context>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr__ctor_Public_Void_Context_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x000500CC File Offset: 0x0004E2CC
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 574808, RefRangeEnd = 574874, XrefRangeStart = 574806, XrefRangeEnd = 574808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context CopyParameters(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CopyParameters_Public_Context_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0005011C File Offset: 0x0004E31C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 574894, RefRangeEnd = 574901, XrefRangeStart = 574874, XrefRangeEnd = 574894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context CopyParameters(Dictionary<string, Object> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CopyParameters_Public_Context_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0005016C File Offset: 0x0004E36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574901, XrefRangeEnd = 574919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> GetTargets<T>(Match m) where T : Entity
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.MethodInfoStoreGeneric_GetTargets_Public_List_1_T_Match_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000501BC File Offset: 0x0004E3BC
		[CallerCount(163)]
		[CachedScanResults(RefRangeStart = 574922, RefRangeEnd = 575085, XrefRangeStart = 574919, XrefRangeEnd = 574922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TargetIs<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.MethodInfoStoreGeneric_TargetIs_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x000501F8 File Offset: 0x0004E3F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 575090, RefRangeEnd = 575094, XrefRangeStart = 575085, XrefRangeEnd = 575090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetTarget<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.MethodInfoStoreGeneric_GetTarget_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00050234 File Offset: 0x0004E434
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 575097, RefRangeEnd = 575105, XrefRangeStart = 575094, XrefRangeEnd = 575097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetTarget<T>(out T oTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref oTarget;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Context.MethodInfoStoreGeneric_TryGetTarget_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					oTarget = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x000502C0 File Offset: 0x0004E4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575105, XrefRangeEnd = 575115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity GetTargetEntity(Match m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetTargetEntity_Public_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00050310 File Offset: 0x0004E510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575115, XrefRangeEnd = 575123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity GetFirstSelection(Match m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetFirstSelection_Public_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00050360 File Offset: 0x0004E560
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 575137, RefRangeEnd = 575146, XrefRangeStart = 575123, XrefRangeEnd = 575137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context WithTarget(Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_WithTarget_Public_Context_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x000503B0 File Offset: 0x0004E5B0
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 575153, RefRangeEnd = 575193, XrefRangeStart = 575146, XrefRangeEnd = 575153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context WithParameter(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_WithParameter_Public_Context_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00050414 File Offset: 0x0004E614
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 575228, RefRangeEnd = 575237, XrefRangeStart = 575193, XrefRangeEnd = 575228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedContext Serialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_Serialized_Public_SerializedContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedContext>(intPtr3) : null;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00050454 File Offset: 0x0004E654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575237, XrefRangeEnd = 575288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00050498 File Offset: 0x0004E698
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 575509, RefRangeEnd = 575513, XrefRangeStart = 575288, XrefRangeEnd = 575509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Calcified(Object unknown, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unknown);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_Calcified_Public_Static_String_Object_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000504E8 File Offset: 0x0004E6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575513, XrefRangeEnd = 575534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityID_PDM_0(IEnumerable enumerable, out List<EntityID> entityIDs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityID_PDM_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entityIDs = ((intPtr4 == 0) ? null : new List<EntityID>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0005054C File Offset: 0x0004E74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575534, XrefRangeEnd = 575556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityIDTargetResponses_PDM_0(IEnumerable enumerable, out List<EntityIDTargetResponses> eidTRs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityIDTargetResponses_PDM_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			eidTRs = ((intPtr4 == 0) ? null : new List<EntityIDTargetResponses>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000505B0 File Offset: 0x0004E7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575556, XrefRangeEnd = 575578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityIDEntityTargetsResponse_PDM_0(IEnumerable enumerable, out List<EntityIDEntityTargetsResponse> eidEntityTRs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityIDEntityTargetsResponse_PDM_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			eidEntityTRs = ((intPtr4 == 0) ? null : new List<EntityIDEntityTargetsResponse>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000066ED File Offset: 0x000048ED
		public Context(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00050614 File Offset: 0x0004E814
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x000066F6 File Offset: 0x000048F6
		public unsafe Object target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00050644 File Offset: 0x0004E844
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00006715 File Offset: 0x00004915
		public unsafe Entity Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00050674 File Offset: 0x0004E874
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00006734 File Offset: 0x00004934
		public unsafe Dictionary<string, Object> parameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_parameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeFieldInfoPtr_parameters;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Entity_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_get_Parameters_Public_get_Dictionary_2_String_Object_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Context_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Context_String_Object_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Object_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Context_Object_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_CopyParameters_Public_Context_Context_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_CopyParameters_Public_Context_Dictionary_2_String_Object_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_GetTargets_Public_List_1_T_Match_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_TargetIs_Public_Boolean_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_GetTarget_Public_T_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTarget_Public_Boolean_byref_T_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetEntity_Public_Entity_Match_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstSelection_Public_Entity_Match_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_WithTarget_Public_Context_Object_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_WithParameter_Public_Context_String_Object_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_Serialized_Public_SerializedContext_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_Calcified_Public_Static_String_Object_Match_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityID_PDM_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityIDTargetResponses_PDM_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_byref_List_1_EntityIDEntityTargetsResponse_PDM_0;

		// Token: 0x0200037C RID: 892
		[ObfuscatedName("Canis.context.Context+<>c__DisplayClass14_0`1")]
		public sealed class __c__DisplayClass14_0<T> : Object where T : Entity
		{
			// Token: 0x06002578 RID: 9592 RVA: 0x000A6220 File Offset: 0x000A4420
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<Context.__c__DisplayClass14_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Context>.NativeClassPtr, "<>c__DisplayClass14_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Context.__c__DisplayClass14_0<T>>.NativeClassPtr);
				Context.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context.__c__DisplayClass14_0<T>>.NativeClassPtr, "m");
				Context.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context.__c__DisplayClass14_0<T>>.NativeClassPtr, 100666221);
				Context.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__GetTargets_b__0_Internal_IEnumerable_1_T_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context.__c__DisplayClass14_0<T>>.NativeClassPtr, 100666222);
			}

			// Token: 0x06002579 RID: 9593 RVA: 0x000A62C4 File Offset: 0x000A44C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Context.__c__DisplayClass14_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600257A RID: 9594 RVA: 0x000A6300 File Offset: 0x000A4500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574238, XrefRangeEnd = 574240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<T> _GetTargets_b__0(EntityID eid)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__GetTargets_b__0_Internal_IEnumerable_1_T_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
				}
			}

			// Token: 0x0600257B RID: 9595 RVA: 0x00011E75 File Offset: 0x00010075
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000937 RID: 2359
			// (get) Token: 0x0600257C RID: 9596 RVA: 0x000A6350 File Offset: 0x000A4550
			// (set) Token: 0x0600257D RID: 9597 RVA: 0x00011E7E File Offset: 0x0001007E
			public unsafe Match m
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_m);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_m), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400176E RID: 5998
			private static readonly IntPtr NativeFieldInfoPtr_m;

			// Token: 0x0400176F RID: 5999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001770 RID: 6000
			private static readonly IntPtr NativeMethodInfoPtr__GetTargets_b__0_Internal_IEnumerable_1_T_EntityID_0;
		}

		// Token: 0x0200037D RID: 893
		private sealed class MethodInfoStoreGeneric_GetTargets_Public_List_1_T_Match_0<T>
		{
			// Token: 0x04001771 RID: 6001
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Context.NativeMethodInfoPtr_GetTargets_Public_List_1_T_Match_0, Il2CppClassPointerStore<Context>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200037E RID: 894
		private sealed class MethodInfoStoreGeneric_TargetIs_Public_Boolean_0<T>
		{
			// Token: 0x04001772 RID: 6002
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Context.NativeMethodInfoPtr_TargetIs_Public_Boolean_0, Il2CppClassPointerStore<Context>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200037F RID: 895
		private sealed class MethodInfoStoreGeneric_GetTarget_Public_T_0<T>
		{
			// Token: 0x04001773 RID: 6003
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Context.NativeMethodInfoPtr_GetTarget_Public_T_0, Il2CppClassPointerStore<Context>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000380 RID: 896
		private sealed class MethodInfoStoreGeneric_TryGetTarget_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x04001774 RID: 6004
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Context.NativeMethodInfoPtr_TryGetTarget_Public_Boolean_byref_T_0, Il2CppClassPointerStore<Context>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
