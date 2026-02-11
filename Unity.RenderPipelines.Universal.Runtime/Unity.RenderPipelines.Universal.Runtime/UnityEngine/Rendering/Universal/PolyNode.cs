using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200000D RID: 13
	public class PolyNode : Object
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x0001770C File Offset: 0x0001590C
		// Note: this type is marked as 'beforefieldinit'.
		static PolyNode()
		{
			Il2CppClassPointerStore<PolyNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PolyNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolyNode>.NativeClassPtr);
			PolyNode.NativeFieldInfoPtr_m_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, "m_Parent");
			PolyNode.NativeFieldInfoPtr_m_polygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, "m_polygon");
			PolyNode.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, "m_Index");
			PolyNode.NativeFieldInfoPtr_m_jointype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, "m_jointype");
			PolyNode.NativeFieldInfoPtr_m_endtype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, "m_endtype");
			PolyNode.NativeFieldInfoPtr_m_Childs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, "m_Childs");
			PolyNode.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, "<IsOpen>k__BackingField");
			PolyNode.NativeMethodInfoPtr_IsHoleNode_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663391);
			PolyNode.NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663392);
			PolyNode.NativeMethodInfoPtr_get_Contour_Public_get_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663393);
			PolyNode.NativeMethodInfoPtr_AddChild_Internal_Void_PolyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663394);
			PolyNode.NativeMethodInfoPtr_GetNext_Public_PolyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663395);
			PolyNode.NativeMethodInfoPtr_GetNextSiblingUp_Internal_PolyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663396);
			PolyNode.NativeMethodInfoPtr_get_Childs_Public_get_List_1_PolyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663397);
			PolyNode.NativeMethodInfoPtr_get_Parent_Public_get_PolyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663398);
			PolyNode.NativeMethodInfoPtr_get_IsHole_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663399);
			PolyNode.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663400);
			PolyNode.NativeMethodInfoPtr_set_IsOpen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663401);
			PolyNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyNode>.NativeClassPtr, 100663402);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000178B8 File Offset: 0x00015AB8
		[CallerCount(0)]
		public unsafe bool IsHoleNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_IsHoleNode_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000178F4 File Offset: 0x00015AF4
		public unsafe int ChildCount
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 596940, RefRangeEnd = 596951, XrefRangeStart = 596939, XrefRangeEnd = 596940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00017930 File Offset: 0x00015B30
		public unsafe List<IntPoint> Contour
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_get_Contour_Public_get_List_1_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IntPoint>>(intPtr3) : null;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00017970 File Offset: 0x00015B70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 596958, RefRangeEnd = 596961, XrefRangeStart = 596951, XrefRangeEnd = 596958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(PolyNode Child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_AddChild_Internal_Void_PolyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000179B4 File Offset: 0x00015BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596961, XrefRangeEnd = 596967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolyNode GetNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_GetNext_Public_PolyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PolyNode>(intPtr3) : null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000179F4 File Offset: 0x00015BF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 596972, RefRangeEnd = 596974, XrefRangeStart = 596967, XrefRangeEnd = 596972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolyNode GetNextSiblingUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_GetNextSiblingUp_Internal_PolyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PolyNode>(intPtr3) : null;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00017A34 File Offset: 0x00015C34
		public unsafe List<PolyNode> Childs
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_get_Childs_Public_get_List_1_PolyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PolyNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00017A74 File Offset: 0x00015C74
		public unsafe PolyNode Parent
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_get_Parent_Public_get_PolyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PolyNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00017AB4 File Offset: 0x00015CB4
		public unsafe bool IsHole
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_get_IsHole_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00017AF0 File Offset: 0x00015CF0
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00017B2C File Offset: 0x00015D2C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr_set_IsOpen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00017B6C File Offset: 0x00015D6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 596989, RefRangeEnd = 596993, XrefRangeStart = 596974, XrefRangeEnd = 596989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolyNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolyNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000024B9 File Offset: 0x000006B9
		public PolyNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00017BA8 File Offset: 0x00015DA8
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000024C2 File Offset: 0x000006C2
		public unsafe PolyNode m_Parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_Parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolyNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00017BD8 File Offset: 0x00015DD8
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000024E1 File Offset: 0x000006E1
		public unsafe List<IntPoint> m_polygon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_polygon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_polygon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00017C08 File Offset: 0x00015E08
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002500 File Offset: 0x00000700
		public unsafe int m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00017C30 File Offset: 0x00015E30
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000251B File Offset: 0x0000071B
		public unsafe JoinType m_jointype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_jointype);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_jointype)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00017C58 File Offset: 0x00015E58
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002536 File Offset: 0x00000736
		public unsafe EndType m_endtype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_endtype);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_endtype)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00017C80 File Offset: 0x00015E80
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002551 File Offset: 0x00000751
		public unsafe List<PolyNode> m_Childs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_Childs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PolyNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr_m_Childs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00017CB0 File Offset: 0x00015EB0
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002570 File Offset: 0x00000770
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyNode.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_m_Parent;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_m_polygon;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_m_jointype;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_m_endtype;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_m_Childs;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_IsHoleNode_Private_Boolean_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_Contour_Public_get_List_1_IntPoint_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Internal_Void_PolyNode_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Public_PolyNode_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSiblingUp_Internal_PolyNode_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_Childs_Public_get_List_1_PolyNode_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_PolyNode_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHole_Public_get_Boolean_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Public_set_Void_Boolean_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
