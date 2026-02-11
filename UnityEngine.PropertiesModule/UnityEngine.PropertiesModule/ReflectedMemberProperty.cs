using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x0200000D RID: 13
	public class ReflectedMemberProperty<TContainer, TValue> : Property<TContainer, TValue>
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00004668 File Offset: 0x00002868
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectedMemberProperty()
		{
			Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "ReflectedMemberProperty`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr);
			ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "m_Info");
			ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_IsStructContainerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "m_IsStructContainerType");
			ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_GetStructValueAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "m_GetStructValueAction");
			ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_SetStructValueAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "m_SetStructValueAction");
			ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_GetClassValueAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "m_GetClassValueAction");
			ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_SetClassValueAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "m_SetClassValueAction");
			ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "<Name>k__BackingField");
			ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr__IsReadOnly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "<IsReadOnly>k__BackingField");
			ReflectedMemberProperty<TContainer, TValue>.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, 100663326);
			ReflectedMemberProperty<TContainer, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_IMemberInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, 100663327);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000047B0 File Offset: 0x000029B0
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectedMemberProperty<TContainer, TValue>.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000047F4 File Offset: 0x000029F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230655, XrefRangeEnd = 1230669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectedMemberProperty(IMemberInfo info, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedMemberProperty<TContainer, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_IMemberInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000022E4 File Offset: 0x000004E4
		public ReflectedMemberProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00004854 File Offset: 0x00002A54
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000022ED File Offset: 0x000004ED
		public unsafe IMemberInfo m_Info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_Info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_Info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00004884 File Offset: 0x00002A84
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000230C File Offset: 0x0000050C
		public unsafe bool m_IsStructContainerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_IsStructContainerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_IsStructContainerType)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000048AC File Offset: 0x00002AAC
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002327 File Offset: 0x00000527
		public unsafe ReflectedMemberProperty<TContainer, TValue>.GetStructValueAction m_GetStructValueAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_GetStructValueAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectedMemberProperty<TContainer, TValue>.GetStructValueAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_GetStructValueAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000048DC File Offset: 0x00002ADC
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002346 File Offset: 0x00000546
		public unsafe ReflectedMemberProperty<TContainer, TValue>.SetStructValueAction m_SetStructValueAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_SetStructValueAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectedMemberProperty<TContainer, TValue>.SetStructValueAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_SetStructValueAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000490C File Offset: 0x00002B0C
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002365 File Offset: 0x00000565
		public unsafe ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction m_GetClassValueAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_GetClassValueAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_GetClassValueAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000493C File Offset: 0x00002B3C
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002384 File Offset: 0x00000584
		public unsafe ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction m_SetClassValueAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_SetClassValueAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr_m_SetClassValueAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000496C File Offset: 0x00002B6C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000023A3 File Offset: 0x000005A3
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00004994 File Offset: 0x00002B94
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000023C2 File Offset: 0x000005C2
		public unsafe bool _IsReadOnly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr__IsReadOnly_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedMemberProperty<TContainer, TValue>.NativeFieldInfoPtr__IsReadOnly_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000023DD File Offset: 0x000005DD
		public override bool IsReadOnly
		{
			get
			{
				return this._IsReadOnly_k__BackingField;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000049BC File Offset: 0x00002BBC
		public override TValue GetValue(ref TContainer container)
		{
			bool isStructContainerType = this.m_IsStructContainerType;
			TValue tvalue;
			if (isStructContainerType)
			{
				tvalue = ((this.m_GetStructValueAction == null) ? this.m_Info.GetValue(container).Cast<TValue>() : this.m_GetStructValueAction.Invoke(ref container));
			}
			else
			{
				tvalue = ((this.m_GetClassValueAction == null) ? this.m_Info.GetValue(container).Cast<TValue>() : this.m_GetClassValueAction.Invoke(container));
			}
			return tvalue;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004A44 File Offset: 0x00002C44
		public override void SetValue(ref TContainer container, TValue value)
		{
			bool isReadOnly = this.IsReadOnly;
			if (isReadOnly)
			{
				throw new InvalidOperationException("Property is ReadOnly.");
			}
			bool isStructContainerType = this.m_IsStructContainerType;
			if (isStructContainerType)
			{
				bool flag = this.m_SetStructValueAction == null;
				if (flag)
				{
					Object @object = container;
					this.m_Info.SetValue(@object, value);
					container = @object.Cast<TContainer>();
				}
				else
				{
					this.m_SetStructValueAction.Invoke(ref container, value);
				}
			}
			else
			{
				bool flag2 = this.m_SetClassValueAction == null;
				if (flag2)
				{
					this.m_Info.SetValue(container, value);
				}
				else
				{
					this.m_SetClassValueAction.Invoke(container, value);
				}
			}
		}

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_m_Info;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_m_IsStructContainerType;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_m_GetStructValueAction;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_m_SetStructValueAction;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_m_GetClassValueAction;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_m_SetClassValueAction;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr__IsReadOnly_k__BackingField;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IMemberInfo_String_0;

		// Token: 0x0200005C RID: 92
		public sealed class GetStructValueAction : MulticastDelegate
		{
			// Token: 0x060001EA RID: 490 RVA: 0x00008524 File Offset: 0x00006724
			// Note: this type is marked as 'beforefieldinit'.
			static GetStructValueAction()
			{
				Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.GetStructValueAction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "GetStructValueAction"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				ReflectedMemberProperty<TContainer, TValue>.GetStructValueAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.GetStructValueAction>.NativeClassPtr, 100663328);
				ReflectedMemberProperty<TContainer, TValue>.GetStructValueAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_byref_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.GetStructValueAction>.NativeClassPtr, 100663329);
			}

			// Token: 0x060001EB RID: 491 RVA: 0x000085BC File Offset: 0x000067BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetStructValueAction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.GetStructValueAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedMemberProperty<TContainer, TValue>.GetStructValueAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001EC RID: 492 RVA: 0x00008618 File Offset: 0x00006818
			[CallerCount(0)]
			public unsafe TValue Invoke(ref TContainer container)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(container);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReflectedMemberProperty<TContainer, TValue>.GetStructValueAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_byref_TContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					container = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TContainer>(intPtr4, false, false));
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}

			// Token: 0x060001ED RID: 493 RVA: 0x000030C6 File Offset: 0x000012C6
			public GetStructValueAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040000E7 RID: 231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000E8 RID: 232
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_byref_TContainer_0;
		}

		// Token: 0x0200005D RID: 93
		public sealed class SetStructValueAction : MulticastDelegate
		{
			// Token: 0x060001EE RID: 494 RVA: 0x0000867C File Offset: 0x0000687C
			// Note: this type is marked as 'beforefieldinit'.
			static SetStructValueAction()
			{
				Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.SetStructValueAction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "SetStructValueAction"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				ReflectedMemberProperty<TContainer, TValue>.SetStructValueAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.SetStructValueAction>.NativeClassPtr, 100663330);
				ReflectedMemberProperty<TContainer, TValue>.SetStructValueAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_TContainer_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.SetStructValueAction>.NativeClassPtr, 100663331);
			}

			// Token: 0x060001EF RID: 495 RVA: 0x00008714 File Offset: 0x00006914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetStructValueAction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.SetStructValueAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedMemberProperty<TContainer, TValue>.SetStructValueAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x00008770 File Offset: 0x00006970
			[CallerCount(0)]
			public unsafe void Invoke(ref TContainer container, TValue value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(container);
					ptr2 = &intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReflectedMemberProperty<TContainer, TValue>.SetStructValueAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_TContainer_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				container = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TContainer>(intPtr5, false, false));
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x000030CF File Offset: 0x000012CF
			public SetStructValueAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040000E9 RID: 233
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000EA RID: 234
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_TContainer_TValue_0;
		}

		// Token: 0x0200005E RID: 94
		public sealed class GetClassValueAction : MulticastDelegate
		{
			// Token: 0x060001F2 RID: 498 RVA: 0x00008814 File Offset: 0x00006A14
			// Note: this type is marked as 'beforefieldinit'.
			static GetClassValueAction()
			{
				Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "GetClassValueAction"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction>.NativeClassPtr, 100663332);
				ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction>.NativeClassPtr, 100663333);
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x000088AC File Offset: 0x00006AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230637, XrefRangeEnd = 1230646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetClassValueAction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x00008908 File Offset: 0x00006B08
			[CallerCount(0)]
			public unsafe TValue Invoke(TContainer container)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TContainer).IsValueType)
					{
						TContainer tcontainer = container;
						intPtr = ((tcontainer is string) ? IL2CPP.ManagedStringToIl2Cpp(tcontainer as string) : IL2CPP.Il2CppObjectBaseToPtr(tcontainer as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref container;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x000030D8 File Offset: 0x000012D8
			public GetClassValueAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x000030E1 File Offset: 0x000012E1
			public static implicit operator ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction(Func<TContainer, TValue> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction>(A_0);
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x000030E9 File Offset: 0x000012E9
			public static ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction operator +(ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction A_0, ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction>();
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x000030F7 File Offset: 0x000012F7
			public static ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction operator -(ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction A_0, ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectedMemberProperty<TContainer, TValue>.GetClassValueAction>();
				}
				return delegate2;
			}

			// Token: 0x040000EB RID: 235
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000EC RID: 236
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TContainer_0;
		}

		// Token: 0x0200005F RID: 95
		public sealed class SetClassValueAction : MulticastDelegate
		{
			// Token: 0x060001F9 RID: 505 RVA: 0x00008988 File Offset: 0x00006B88
			// Note: this type is marked as 'beforefieldinit'.
			static SetClassValueAction()
			{
				Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>>.NativeClassPtr, "SetClassValueAction"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction>.NativeClassPtr, 100663334);
				ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TContainer_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction>.NativeClassPtr, 100663335);
			}

			// Token: 0x060001FA RID: 506 RVA: 0x00008A20 File Offset: 0x00006C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230646, XrefRangeEnd = 1230655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetClassValueAction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001FB RID: 507 RVA: 0x00008A7C File Offset: 0x00006C7C
			[CallerCount(0)]
			public unsafe void Invoke(TContainer container, TValue value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TContainer).IsValueType)
					{
						TContainer tcontainer = container;
						intPtr = ((tcontainer is string) ? IL2CPP.ManagedStringToIl2Cpp(tcontainer as string) : IL2CPP.Il2CppObjectBaseToPtr(tcontainer as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref container;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TContainer_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}

			// Token: 0x060001FC RID: 508 RVA: 0x00003108 File Offset: 0x00001308
			public SetClassValueAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001FD RID: 509 RVA: 0x00003111 File Offset: 0x00001311
			public static implicit operator ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction(Action<TContainer, TValue> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction>(A_0);
			}

			// Token: 0x060001FE RID: 510 RVA: 0x00003119 File Offset: 0x00001319
			public static ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction operator +(ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction A_0, ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction>();
			}

			// Token: 0x060001FF RID: 511 RVA: 0x00003127 File Offset: 0x00001327
			public static ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction operator -(ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction A_0, ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectedMemberProperty<TContainer, TValue>.SetClassValueAction>();
				}
				return delegate2;
			}

			// Token: 0x040000ED RID: 237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000EE RID: 238
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TContainer_TValue_0;
		}
	}
}
