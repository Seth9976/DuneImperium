using System;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Core
{
	// Token: 0x02000050 RID: 80
	public class TweenerCore<T1, T2, TPlugOptions> : Tweener where TPlugOptions : new()
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x0001C36C File Offset: 0x0001A56C
		// Note: this type is marked as 'beforefieldinit'.
		static TweenerCore()
		{
			Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "TweenerCore`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr);
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_startValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "startValue");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "endValue");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_changeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "changeValue");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_plugOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "plugOptions");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "getter");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_setter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "setter");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_tweenPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "tweenPlugin");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr__TxtCantChangeSequencedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "_TxtCantChangeSequencedValues");
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664273);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeStartValue_Public_Virtual_Tweener_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664274);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664275);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664276);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeValues_Public_Virtual_Tweener_Object_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664277);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Internal_Virtual_Tweener_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664278);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Reset_Internal_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664279);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664280);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664281);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664282);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664283);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0001C578 File Offset: 0x0001A778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134627, RefRangeEnd = 1134628, XrefRangeStart = 1134601, XrefRangeEnd = 1134627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenerCore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0001C5B4 File Offset: 0x0001A7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134628, XrefRangeEnd = 1134663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Tweener ChangeStartValue(Object newStartValue, float newDuration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStartValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeStartValue_Public_Virtual_Tweener_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001C620 File Offset: 0x0001A820
		[CallerCount(0)]
		public unsafe override Tweener ChangeEndValue(Object newEndValue, bool snapStartValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEndValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStartValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001C68C File Offset: 0x0001A88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134663, XrefRangeEnd = 1134698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Tweener ChangeEndValue(Object newEndValue, float newDuration = -1f, bool snapStartValue = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEndValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStartValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001C704 File Offset: 0x0001A904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134698, XrefRangeEnd = 1134711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Tweener ChangeValues(Object newStartValue, Object newEndValue, float newDuration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStartValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newEndValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeValues_Public_Virtual_Tweener_Object_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001C780 File Offset: 0x0001A980
		[CallerCount(0)]
		public unsafe override Tweener SetFrom(bool relative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relative;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Internal_Virtual_Tweener_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001C7D8 File Offset: 0x0001A9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134711, XrefRangeEnd = 1134715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Reset_Internal_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001C80C File Offset: 0x0001AA0C
		[CallerCount(0)]
		public unsafe override bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001C854 File Offset: 0x0001AA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134715, XrefRangeEnd = 1134716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float UpdateDelay(float elapsed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elapsed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134716, XrefRangeEnd = 1134724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Startup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001C8F0 File Offset: 0x0001AAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134724, XrefRangeEnd = 1134730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref prevPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevCompletedLoops;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCompletedSteps;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInversePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00003ACA File Offset: 0x00001CCA
		public TweenerCore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0001C98C File Offset: 0x0001AB8C
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x0001C9B4 File Offset: 0x0001ABB4
		public unsafe T2 startValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_startValue);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_startValue);
				Type typeFromHandle = typeof(T2);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0001CA5C File Offset: 0x0001AC5C
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x0001CA84 File Offset: 0x0001AC84
		public unsafe T2 endValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_endValue);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_endValue);
				Type typeFromHandle = typeof(T2);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001CB2C File Offset: 0x0001AD2C
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x0001CB54 File Offset: 0x0001AD54
		public unsafe T2 changeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_changeValue);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_changeValue);
				Type typeFromHandle = typeof(T2);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001CBFC File Offset: 0x0001ADFC
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0001CC24 File Offset: 0x0001AE24
		public unsafe TPlugOptions plugOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_plugOptions);
				return IL2CPP.PointerToValueGeneric<TPlugOptions>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_plugOptions);
				Type typeFromHandle = typeof(TPlugOptions);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0001CCCC File Offset: 0x0001AECC
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00003AD3 File Offset: 0x00001CD3
		public unsafe DOGetter<T1> getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DOGetter<T1>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0001CCFC File Offset: 0x0001AEFC
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00003AF2 File Offset: 0x00001CF2
		public unsafe DOSetter<T1> setter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_setter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DOSetter<T1>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_setter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0001CD2C File Offset: 0x0001AF2C
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00003B11 File Offset: 0x00001D11
		public unsafe ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_tweenPlugin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ABSTweenPlugin<T1, T2, TPlugOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_tweenPlugin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0001CD5C File Offset: 0x0001AF5C
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00003B30 File Offset: 0x00001D30
		public unsafe static string _TxtCantChangeSequencedValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr__TxtCantChangeSequencedValues, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr__TxtCantChangeSequencedValues, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_startValue;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_endValue;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_changeValue;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_plugOptions;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_getter;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_setter;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_tweenPlugin;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr__TxtCantChangeSequencedValues;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_ChangeStartValue_Public_Virtual_Tweener_Object_Single_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Boolean_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Single_Boolean_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValues_Public_Virtual_Tweener_Object_Object_Single_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Internal_Virtual_Tweener_Boolean_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_Final_Void_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_Single_Single_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0;
	}
}
